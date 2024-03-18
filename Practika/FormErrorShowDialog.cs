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
            label2.Text = secondString;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
