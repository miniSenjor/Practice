using System;
using System.Windows.Forms;

namespace Practika
{
    public partial class FormErrorShowDialog : Form
    {
        public FormErrorShowDialog(string secondString, string firstString="")
        {
            InitializeComponent();
            label1.Text = firstString;
            if (secondString.Length >50)
            {
                label2.Text = secondString.Substring(0, 50);
                label3.Text = secondString.Substring(50);
            }
            else
                label2.Text = secondString;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
