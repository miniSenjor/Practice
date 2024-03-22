using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class FormMakePuchase : Form
    {
        public FormMakePuchase(int idProduct, string productName, int price, int max, int idUser, SqlConnection conn)
        {
            InitializeComponent();
            IdProduct = idProduct;
            ProductName = productName;
            Max = max;
            IdUser = idUser;
            sqlConn = conn;
            Price = price;
        }

        private int IdProduct;
        private string ProductName;
        private int Max;
        private int Price;
        private int IdUser;
        private SqlConnection sqlConn;

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            int quntity = int.Parse(nudQunatityProduct.Value.ToString());
            SqlCommand command = new SqlCommand($"INSERT INTO Purchase (user_id, product_id, quantity, price) VALUES ('{IdUser}', '{IdProduct}', {quntity}, {Price*quntity})", sqlConn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"UPDATE Product SET quantity = quantity - {quntity} WHERE id = {IdProduct};", sqlConn);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void FormMakePuchase_Load(object sender, EventArgs e)
        {
            lblProductName.Text = ProductName;
            nudQunatityProduct.Maximum = Max;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
