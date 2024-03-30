using System;
using System.Windows.Forms;

namespace Practika
{
    public partial class FormMakePuchase : Form
    {
        private DB db;
        public FormMakePuchase(int idProduct, string productName, int price, int max, int idUser)
        {
            InitializeComponent();
            IdProduct = idProduct;
            ProductName = productName;
            Max = max;
            IdUser = idUser;
            Price = price;
            db = new DB();
        }

        private int IdProduct;
        private string ProductName;
        private int Max;
        private int Price;
        private int IdUser;

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            FormErrorShowDialog form;
            int quntity = Convert.ToInt32(nudQunatityProduct.Value);
            if (quntity<=0 || quntity>Max)
            {
                form = new FormErrorShowDialog("Ошибка ввода количества", "Ошибка");
                form.ShowDialog();
                return;
            }
            string query = $"INSERT INTO Purchase (user_id, product_id, quantity, price) VALUES ('{IdUser}', '{IdProduct}', {quntity}, {Price * quntity})";
            db.SqlSimpleQuery(query);
            query = $"UPDATE Product SET quantity = quantity - {quntity} WHERE id = {IdProduct};";
            db.SqlSimpleQuery(query);
            form = new FormErrorShowDialog("Заказ успешно создан", "Успех");
            form.ShowDialog();
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
