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
    public partial class FormMakePuchase : Form
    {
        public FormMakePuchase(string product, int price, int max, string login)
        {
            InitializeComponent();
            Product = product;
            Max = max;
            Login = login;
        }

        private string Product;
        private int Max;
        private string Login;

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
