using System;
using System.Windows.Forms;

namespace Practika
{
    public partial class FormLogin : Form
    {
        private DB db;
        public FormLogin()
        {
            db = new DB();
            InitializeComponent();
        }

        string role;
        int idUser;

        private void btnReg_Click(object sender, EventArgs e)
        {
            string pas1 = txtPasswordReg1.Text;
            string pas2 = txtPasswordReg2.Text;
            string log = txtLoginReg.Text;

            string query = $"SELECT * FROM [dbo].[User] WHERE login = '{log}'";
            if (pas1 != pas2 || log == "" || db.SqlScalarQuery(query) != null)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль", "Ошибка");
                formError.ShowDialog();
                return;
            }
            query = $"INSERT INTO [dbo].[User] (login, password, role) VALUES ('{log}', '{pas1}', 'user')";
            db.SqlSimpleQuery(query);
            ClearTxtReg();
            ClearTxtEntr();
            showMainForm(log, pas1);
            return;
        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            string pas = txtPasswordEntr.Text;
            string log = txtLoginEntr.Text;
            string query = $"SELECT * FROM [dbo].[User] WHERE login = '{log}' AND password = '{pas}';";
            if (log == "" || db.SqlScalarQuery(query) == null)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль", "Ошибка");
                formError.ShowDialog();
                return;
            }
            ClearTxtReg();
            ClearTxtEntr();
            showMainForm(log, pas);
            return;
        }

        /// <summary>
        /// Загрузка главной формы
        /// </summary>
        /// <param name="log">логин пользователя</param>
        /// <param name="pas">пароль пользователя</param>
        private void showMainForm(string log, string pas)
        {
            string query, answer;
            query = $"SELECT id FROM [dbo].[User] WHERE login = '{log}' AND password = '{pas}';";
            idUser = Convert.ToInt32(db.ReturnStringValue(query, out answer));
            query = $"SELECT role FROM [dbo].[User] WHERE id = '{idUser}';";
            role = db.ReturnStringValue(query, out answer);
            Form1 form = new Form1(role, log, idUser);
            this.Visible = false;
            form.ShowDialog();
            try
            {
                this.Visible = true;
            }
            catch { }
            return;
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
        private void iBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void iBtnRegClear_Click(object sender, EventArgs e)
        {
            ClearTxtReg();
        }

        private void iBtnEntrClear_Click(object sender, EventArgs e)
        {
            ClearTxtEntr();
        }

        private void ClearTxtEntr()
        {
            txtLoginEntr.Text = "";
            txtPasswordEntr.Text = "";
        }

        private void ClearTxtReg()
        {
            txtLoginReg.Text = "";
            txtPasswordReg1.Text = "";
            txtPasswordReg2.Text = "";
        }
    }
}
