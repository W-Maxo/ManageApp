using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ManageApp.Properties;

namespace ManageApp
{
    public partial class MainForm : Form
    {
        private readonly Queue<string> _queue;

        public Socket MClientSocket;
        private int _indx = 1;

        private string _dtstring;

        public MainForm()
        {
            InitializeComponent();

            _queue=new Queue<string>();
        }

        private void ToolStripButton2Click(object sender, EventArgs e)
        {
            if (MClientSocket != null)
            {
                MClientSocket.Close();
                MClientSocket = null;
            }
            Close();
        }

        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            var cs = new ConectionSettings();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UpdateControls(false);
                    MClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    int iPortNo = int.Parse(cs.ServerPort);

                    var ipEnd = new DnsEndPoint(cs.ServerName, iPortNo);

                    MClientSocket.Connect(ipEnd);
                    if (MClientSocket.Connected)
                    {
                        WaitForData();

                        UpdateControls(true);

                        SendMessage(string.Format("{0}\t{1}", cs.UserName, cs.UserPass));
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show(Resources.ConnectFailed + se.Message);
                    UpdateControls(false);
                }
            }
        }

        public void SendMessage(string msg)
        {
            try
            {
                byte[] byData = Encoding.UTF8.GetBytes(msg);
                MClientSocket.Send(byData);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void WaitForData()
        {
            try
            {
                var theSocPkt = new SocketPacket {ThisSocket = MClientSocket};

                MClientSocket.BeginReceive(theSocPkt.DataBuffer,
                                           0, theSocPkt.DataBuffer.Length,
                                           SocketFlags.None,
                                           OnDataReceived,
                                           theSocPkt);
                
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        public class SocketPacket
        {
            public Socket ThisSocket;
            public byte[] DataBuffer = new byte[1024];
        }

        private delegate void DelegateT();
        private void UpdateT()
        {
            listViewLog.BeginUpdate();
            try
            {
                for (int i = 0; i < _queue.Count; i++)
                {
                    string str = _queue.Dequeue();

                    string[] inp = str.Split("\t".ToCharArray(), StringSplitOptions.None);

                    if (inp.Length == 7)
                    {

                        int tp = int.Parse(inp[1]);

                        switch (tp)
                        {
                            case 8:
                                if (MClientSocket != null)
                                    ServerSt.Text = Resources.Server + MClientSocket.RemoteEndPoint;
                                break;

                            case 9:
                                if (MClientSocket != null)
                                {
                                    MClientSocket.Close();
                                    MClientSocket = null;

                                    UpdateControls(false);
                                }
                                break;
                        }

                        try
                        {

                            _dtstring = DateTime.Parse(inp[6], new CultureInfo("en-US", false)).ToString(
                                CultureInfo.InvariantCulture.DateTimeFormat.ShortDatePattern + " " +
                                CultureInfo.InvariantCulture.DateTimeFormat.LongTimePattern);
                        }
                        catch(Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        
                        var col = new[]
                                      {
                                          _indx++.ToString(CultureInfo.InvariantCulture),
                                          _dtstring,
                                          inp[0]
                                      };

                        var d = new ListViewItem(col, 1) {Tag = tp};
                        ListViewItem lvi = listViewLog.Items.Add(d);
                        lvi.ImageIndex = tp;

                        if (AutoScrollButton.Checked) listViewLog.Items[listViewLog.Items.Count - 1].EnsureVisible();

                        clientCountSt.Text = Resources.ClConnected + inp[3];
                        bytesReadSt.Text = Resources.bytesRead + inp[4];
                        bytesWriteSt.Text = Resources.bytesWrite + inp[5];
                    }
                }
            }
            finally
            {
                listViewLog.EndUpdate();
            }
        }

        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                var theSockId = (SocketPacket)asyn.AsyncState;
                int iRx = theSockId.ThisSocket.EndReceive(asyn);

                string str = Encoding.UTF8.GetString(theSockId.DataBuffer, 0, iRx);

                WaitForData();

                string[] td = Regex.Split(str, "<EOF>");

                foreach (var s in td)
                {
                    _queue.Enqueue(s);
                }
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                if (se.ErrorCode == 10054)
                {
                    if (MClientSocket != null)
                    {
                        MClientSocket.Close();
                        MClientSocket = null;

                        if (InvokeRequired)
                        {
                            Invoke(new DelegateC(UpdateControls), false);
                        }
                        else UpdateControls(false);
                    }
                }

                MessageBox.Show(se.Message);
            }
        }

        private delegate void DelegateC(bool connected);
        
        private void UpdateControls(bool connected)
        {
            buttonConnect.Enabled = !connected;
            buttonDisconnect.Enabled = connected;
            string connectStatus = connected ? "Подключен" : "Не подключен";
            textBoxConnectStatus.Text = connectStatus;
        }

        private void ButtonDisconnectClick(object sender, EventArgs e)
        {
            if (MClientSocket != null)
            {
                MClientSocket.Close();
                MClientSocket = null;
                UpdateControls(false);
            }
        }

        private void Timer1Tick(object sender, EventArgs e)
        {

            if (InvokeRequired)
            {
                Invoke(new DelegateT(UpdateT));
            }
            else UpdateT();
        }
    }
}
