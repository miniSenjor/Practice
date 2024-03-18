using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color activeForegroundColor = Color.FromArgb(47, 180, 90);

        private Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

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
        }

        private void iBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.Close();
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
    }
}
