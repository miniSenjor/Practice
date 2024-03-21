﻿using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Practika
{
    public partial class Form1 : Form
    {
        public string Role;
        public Form1(string role)
        {
            InitializeComponent();
            Role = role;
            lbRole.Text = Role;
        }

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color activeForegroundColor = Color.FromArgb(47, 180, 90);

        private Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

        private SqlConnection conn = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TabControl1.TabMenuVisible = false;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString);
            conn.Open();
            List<string> category = new List<string>();
            SqlCommand selectCategory = new SqlCommand("SELECT name FROM Category", conn);
            SqlDataReader reader = selectCategory.ExecuteReader();
            cbCategory.Items.Clear();
            while (reader.Read())
            {
                object value = reader.GetValue(0);
                category.Add(value!=DBNull.Value ? value.ToString() : "");
            }
            cbCategory.Items.AddRange(category.ToArray());
        }

        private void SetButtonColor(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void iBtnHome_Click(object sender, EventArgs e)
        {
            IconButton button = (IconButton) sender;
            SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

            panelLeft1.Visible = true;
            panelLeft2.Visible = false;
            panelLeft3.Visible = false;
            SetButtonColor(iBtnSearch, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColor(iBtnBasket, defaultBackgroundColor, defaultForegroundColor);
            guna2TabControl1.SelectedIndex = 0;
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

            panelLeft2.Visible = true;
            panelLeft1.Visible = false;
            panelLeft3.Visible = false;
            SetButtonColor(iBtnHome, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColor(iBtnBasket, defaultBackgroundColor, defaultForegroundColor);
            guna2TabControl1.SelectedIndex = 1;
        }

        private void iBtnBasket_Click(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

            panelLeft3.Visible = true;
            panelLeft2.Visible = false;
            panelLeft1.Visible = false;
            SetButtonColor(iBtnSearch, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColor(iBtnHome, defaultBackgroundColor, defaultForegroundColor);
            guna2TabControl1.SelectedIndex = 2;
        }

        private void iBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iBtnWindowMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iBtnWindowMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterScreen;
                iBtnWindowMax.IconChar= IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                iBtnWindowMax.IconChar = IconChar.WindowMaximize;
            }
        }

        private void iBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во' FROM Product JOIN Category ON Product.id_category = Category.id WHERE Category.name = N'{cbCategory.SelectedItem.ToString()}'; ", conn);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ColumnHeadersHeight = 60;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hhh");
        }
    }
}
