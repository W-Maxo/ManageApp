using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageApp
{
    public partial class ConectionSettings : Form
    {
        public string ServerName { get; private set; }
        public string ServerPort { get; private set; }
        public string UserName { get; private set; }
        public string UserPass { get; private set; }

        public ConectionSettings()
        {
            InitializeComponent();
        }

        private bool ServerNameValidating(object sender)
        {
            var xTextBox = (TextBox)sender;

            if (xTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(xTextBox, "Поле с имененем сервера не может быть пустым");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private bool ServerPortValidating(object sender)
        {
            var xTextBox = (TextBox)sender;

            if (xTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(xTextBox, "Поле с портом сервера не может быть пустым");
                return false;
            }
            if (int.Parse(xTextBox.Text) > 65535)
            {
                errorProvider1.SetError(xTextBox, "Поле порт может принимать значение от 0 до 65535");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private bool UserNameValidating(object sender)
        {
            var xTextBox = (TextBox) sender;

            if (xTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(xTextBox, "Поле с имененем пользователя не может быть пустым");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private bool UserPasswordValidating(object sender)
        {
            var xTextBox = (MaskedTextBox)sender;

            if (xTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(xTextBox, "Поле с имененем пользователя не может быть пустым");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void TextBox1Validating(object sender, CancelEventArgs e)
        {
            ServerNameValidating(sender);
        }

        private void TextBox2KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void TextBox2Validating(object sender, CancelEventArgs e)
        {
            ServerPortValidating(sender);
        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            ServerNameValidating(sender);
  
        }

        private void TextBox2TextChanged(object sender, EventArgs e)
        {
            ServerPortValidating(sender);
        }

        private void TextBox4TextChanged(object sender, EventArgs e)
        {
            UserNameValidating(sender);
        }

        private void TextBox4Validating(object sender, CancelEventArgs e)
        {
            UserNameValidating(sender);
        }

        private void MaskedTextBox1Validating(object sender, CancelEventArgs e)
        {
            UserPasswordValidating(sender);
        }

        private void MaskedTextBox1TextChanged(object sender, EventArgs e)
        {
            UserPasswordValidating(sender);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (ServerNameValidating(serverNameTextBox) &&
                ServerPortValidating(serverPortTextBox) &&
                UserNameValidating(userNameTextBox) &&
                UserPasswordValidating(userPassMaskedTextBox))
            {
                ServerName = serverNameTextBox.Text;
                ServerPort = serverPortTextBox.Text;
                UserName = userNameTextBox.Text;
                UserPass = userPassMaskedTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
