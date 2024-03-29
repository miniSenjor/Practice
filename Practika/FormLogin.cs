﻿using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        private SqlConnection sqlConnection = null;
        string role;
        private void iBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string pas1 = txtPasswordReg1.Text;
            string pas2 = txtPasswordReg2.Text;
            string log = txtLoginReg.Text;
            int idUser;
            SqlCommand command = new SqlCommand($"SELECT * FROM [dbo].[User] WHERE login = '{log}'", sqlConnection);
            if (pas1 != pas2 || log == "" || command.ExecuteScalar() != null)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль");
                formError.ShowDialog();
                return;
            }
            command = new SqlCommand($"INSERT INTO [dbo].[User] (login, password, role) VALUES (N'{log}', N'{pas1}', 'user');", sqlConnection);
            command.ExecuteNonQuery().ToString();
            command = new SqlCommand($"SELECT id FROM [dbo].[User] WHERE login = '{log}' AND password = '{pas1}';", sqlConnection);
            idUser = Convert.ToInt32(command.ExecuteScalar());
            role = "user";
            Form1 form = new Form1(role, log, idUser);
            sqlConnection.Close();
            this.Hide();
            form.ShowDialog();
            return;
        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            string pas = txtPasswordEntr.Text;
            string log = txtLoginEntr.Text;
            int idUser;
            SqlCommand command = new SqlCommand($"SELECT * FROM [dbo].[User] WHERE login = '{log}' AND password = '{pas}';", sqlConnection);
            if (log == "" || command.ExecuteScalar() == null)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Введен неверный логин или пароль");
                formError.ShowDialog();
                return;
            }
            command = new SqlCommand($"SELECT id FROM [dbo].[User] WHERE login = '{log}' AND password = '{pas}';", sqlConnection);
            idUser = Convert.ToInt32(command.ExecuteScalar());
            command = new SqlCommand($"SELECT role FROM [dbo].[User] WHERE id = '{idUser}';", sqlConnection);
            role = command.ExecuteScalar().ToString();
            Form1 form = new Form1(role, log, idUser);
            sqlConnection.Close();
            this.Visible = false;
            form.ShowDialog();
            try
            {
                //this.Visible = true;
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString);
            sqlConnection.Open();
        }
    }
}
