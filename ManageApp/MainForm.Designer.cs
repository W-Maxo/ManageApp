namespace ManageApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated codelistViewLog

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.clientCountSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.bytesReadSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.bytesWriteSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonConnect = new System.Windows.Forms.ToolStripButton();
            this.buttonDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AutoScrollButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listViewLog = new ManageApp.MyListViewEx();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientCountSt,
            this.bytesReadSt,
            this.bytesWriteSt,
            this.ServerSt,
            this.textBoxConnectStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clientCountSt
            // 
            this.clientCountSt.Name = "clientCountSt";
            this.clientCountSt.Size = new System.Drawing.Size(144, 17);
            this.clientCountSt.Text = "Клиентов подключено: 0";
            // 
            // bytesReadSt
            // 
            this.bytesReadSt.Name = "bytesReadSt";
            this.bytesReadSt.Size = new System.Drawing.Size(93, 17);
            this.bytesReadSt.Text = "Байт принято: 0";
            // 
            // bytesWriteSt
            // 
            this.bytesWriteSt.Name = "bytesWriteSt";
            this.bytesWriteSt.Size = new System.Drawing.Size(112, 17);
            this.bytesWriteSt.Text = "Байт отправлено: 0";
            // 
            // ServerSt
            // 
            this.ServerSt.Name = "ServerSt";
            this.ServerSt.Size = new System.Drawing.Size(214, 17);
            this.ServerSt.Spring = true;
            this.ServerSt.Text = "Сервер: 0.0.0.0";
            // 
            // textBoxConnectStatus
            // 
            this.textBoxConnectStatus.MergeIndex = 0;
            this.textBoxConnectStatus.Name = "textBoxConnectStatus";
            this.textBoxConnectStatus.Size = new System.Drawing.Size(88, 17);
            this.textBoxConnectStatus.Text = "Не подключен";
            // 
            // buttonConnect
            // 
            this.buttonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(23, 22);
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisconnect.Image")));
            this.buttonDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(23, 22);
            this.buttonDisconnect.Text = "Отключить";
            this.buttonDisconnect.Click += new System.EventHandler(this.ButtonDisconnectClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Закрыть программу";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonConnect,
            this.buttonDisconnect,
            this.toolStripSeparator1,
            this.AutoScrollButton,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AutoScrollButton
            // 
            this.AutoScrollButton.Checked = true;
            this.AutoScrollButton.CheckOnClick = true;
            this.AutoScrollButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrollButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AutoScrollButton.Image = ((System.Drawing.Image)(resources.GetObject("AutoScrollButton.Image")));
            this.AutoScrollButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoScrollButton.Name = "AutoScrollButton";
            this.AutoScrollButton.Size = new System.Drawing.Size(23, 22);
            this.AutoScrollButton.Text = "Прокрутка списка";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Error.ico");
            this.imageList2.Images.SetKeyName(1, "132.ico");
            this.imageList2.Images.SetKeyName(2, "44.ico");
            this.imageList2.Images.SetKeyName(3, "138.ico");
            this.imageList2.Images.SetKeyName(4, "139.ico");
            this.imageList2.Images.SetKeyName(5, "122.ico");
            this.imageList2.Images.SetKeyName(6, "45.ico");
            this.imageList2.Images.SetKeyName(7, "40.ico");
            this.imageList2.Images.SetKeyName(8, "Plug.ico");
            this.imageList2.Images.SetKeyName(9, "Remv.ico");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.HideSelection = false;
            this.listViewLog.Location = new System.Drawing.Point(0, 25);
            this.listViewLog.MultiSelect = false;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(697, 288);
            this.listViewLog.SmallImageList = this.imageList2;
            this.listViewLog.TabIndex = 3;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата и время";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Событие";
            this.columnHeader9.Width = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 335);
            this.Controls.Add(this.listViewLog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel clientCountSt;
        private System.Windows.Forms.ToolStripStatusLabel bytesReadSt;
        private System.Windows.Forms.ToolStripStatusLabel bytesWriteSt;
        private System.Windows.Forms.ToolStripStatusLabel ServerSt;
        private System.Windows.Forms.ToolStripStatusLabel textBoxConnectStatus;
        private System.Windows.Forms.ToolStripButton buttonConnect;
        private System.Windows.Forms.ToolStripButton buttonDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton AutoScrollButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MyListViewEx listViewLog;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer timer1;
    }
}

