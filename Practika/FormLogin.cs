using System;
using System.Windows.Forms;

namespace Practika
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtPasswordReg1.Text != txtPasswordReg2.Text)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль");
                formError.ShowDialog();
                return;
            }
            this.Close();
        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            if (txtLoginEntr.Text == "")
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль");
                formError.ShowDialog();
                return;
            }
            this.Close();
        }

        private void chkShowPasswordReg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordReg.Checked)
            {
                txtPasswordReg1.PasswordChar = '\0';
                txtPasswordReg2.PasswordChar = '\0';
            }
            else
            {
                txtPasswordReg1.PasswordChar = '*';
                txtPasswordReg2.PasswordChar = '*';
            }
        }

        private void chkShowPasswordEntr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordEntr.Checked)
                txtPasswordEntr.PasswordChar = '\0';
            else
                txtPasswordEntr.PasswordChar = '*';
        }
    }
}
