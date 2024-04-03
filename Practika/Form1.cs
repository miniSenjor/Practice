using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace Practika
{
    public partial class Form1 : Form
    {
        public string Role;
        public string Login;
        public int IdUser;
        private DB db;
        public Form1(string role, string login, int idUser)
        {
            InitializeComponent();
            Role = role;
            lblRole.Text = Role;
            Login = login;
            IdUser = idUser;
            db = new DB();
        }

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color activeForegroundColor = Color.FromArgb(47, 180, 90);

        private Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

        int idProduct = 0, idPurchase = 0;
        string productName, productNamePurchase;
        int price, quantity, pricePurchase, quantityPurchase;

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TabControl1.TabMenuVisible = false;
            if (Role=="user")
            {
                btnChangeProduct.Visible = false;
                btnDeleteProduct.Visible = false;
                btnCreateProduct.Visible = false;
                panelChangeProduct.Visible = false;
            }
            lblLogin.Text = Login;
            lblRoleInHome.Text = Role;
        }

        private void SetButtonColor(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void iBtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                IconButton button = (IconButton)sender;
                SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

                panelLeft1.Visible = true;
                panelLeft2.Visible = false;
                panelLeft3.Visible = false;
                SetButtonColor(iBtnSearch, defaultBackgroundColor, defaultForegroundColor);
                SetButtonColor(iBtnBasket, defaultBackgroundColor, defaultForegroundColor);
                guna2TabControl1.SelectedIndex = 0;

                lblLogin.Text = Login;
                lblRoleInHome.Text = Role;
            }
            catch { }
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IconButton button = (IconButton)sender;
                SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

                panelLeft2.Visible = true;
                panelLeft1.Visible = false;
                panelLeft3.Visible = false;
                SetButtonColor(iBtnHome, defaultBackgroundColor, defaultForegroundColor);
                SetButtonColor(iBtnBasket, defaultBackgroundColor, defaultForegroundColor);
                guna2TabControl1.SelectedIndex = 1;

                updateComboBox(cbCategory, "Category");
                cbCategory.Items.Add("Все");

                string query = $"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;";
                if (db.SqlReturnData(query, dgvProduct)!=null)
                {
                    dgvProduct.ColumnHeadersHeight = 50;
                    dgvProduct.Columns[3].Width = 0;
                }
            }
            catch { }
        }

        /// <summary>
        /// Обновление категорий в выпадающем списке ComboBox
        /// </summary>
        /// <param name="comboBox">ComboBox</param>
        private void updateComboBox(Guna2ComboBox comboBox, string filter)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
            {
                connection.Open();
                if (connection.State != ConnectionState.Open)
                {
                    FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд");
                    formErr.ShowDialog();
                    return;
                }
                List<string> category = new List<string>();
                string query = $"SELECT name FROM {filter}";
                using (SqlCommand selectCategory = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = selectCategory.ExecuteReader();
                    comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        object value = reader.GetValue(0);
                        category.Add(value != DBNull.Value ? value.ToString() : "");
                    }
                }
                comboBox.Items.AddRange(category.ToArray());
            }
        }

        private void iBtnBasket_Click(object sender, EventArgs e)
        {
            try
            {
                IconButton button = (IconButton)sender;
                SetButtonColor(button, activeBackgroundColor, activeForegroundColor);

                panelLeft3.Visible = true;
                panelLeft2.Visible = false;
                panelLeft1.Visible = false;
                SetButtonColor(iBtnSearch, defaultBackgroundColor, defaultForegroundColor);
                SetButtonColor(iBtnHome, defaultBackgroundColor, defaultForegroundColor);
                guna2TabControl1.SelectedIndex = 2;

                string query;
                if (Role=="admin")
                {
                    query = $"SELECT Purchase.id AS 'idPurchase', Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.user_id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id;";
                    lbPurchase.Text = "Все заказы";
                }
                else
                {
                    query = $"SELECT Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id WHERE Purchase.user_id = {IdUser};";
                    lbPurchase.Text = "Ваши заказы";
                }
                db.SqlReturnData(query, dgvPurchase);
                dgvPurchase.ColumnHeadersHeight = 50;
                if (Role != "admin") 
                    dgvPurchase.Columns[3].Width = 0;

                updateComboBox(cbPurchase, "Product");
                cbPurchase.Items.Add("Все");
            }
            catch { }
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
                pictureBox2.Size = new Size(1010, 818);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                iBtnWindowMax.IconChar = IconChar.WindowMaximize;
                pictureBox2.Size = new Size(610, 818);
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
            var category = cbCategory.SelectedItem;
            if (category!=null)
            {
                string selectedCategory = category.ToString();
                string query;
                if (selectedCategory == "Все")
                    query = "SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;";
                else
                    query = $"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product JOIN Category ON Product.id_category = Category.id WHERE Category.name = N'{selectedCategory}';";
                if (db.SqlReturnData(query, dgvProduct)!=null )
                {
                    dgvProduct.ColumnHeadersHeight = 50;
                    dgvProduct.Columns[3].Width = 0;
                }
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                idProduct = Convert.ToInt32(selectedRow.Cells[3].Value);
                string query = $"SELECT c.name FROM Category c JOIN Product p ON c.id = p.id_category WHERE p.id = {idProduct};";
                string category;
                if (db.ReturnStringValue(query, out category)!=null)
                    txtCategory.Text = category;


                productName = selectedRow.Cells[0].Value.ToString();
                txtProductName.Text = productName;
                price = int.Parse(selectedRow.Cells[1].Value.ToString());
                txtPrice.Text = price.ToString();
                quantity = int.Parse(selectedRow.Cells[2].Value.ToString());
                txtQuantity.Text = quantity.ToString();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (idProduct==0)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Не выбран продукт");
                formError.ShowDialog();
                return;
            }
            string query = $"DELETE FROM Product WHERE id = {idProduct};";
            db.SqlSimpleQuery(query);
            idProduct = 0;
            query = $"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;"; ;
            db.SqlReturnData(query, dgvProduct);
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            string category;
            try
            {
                category = txtCategory.Text;
                string productName = txtProductName.Text;
                int price = int.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
            }
            catch 
            {
                FormErrorShowDialog form = new FormErrorShowDialog("Ошибка ввода", "Ошибка");
                return;
            }
            string query = $"DECLARE @id_category INT; " +
                $"SELECT @id_category = id " +
                $"FROM Category " +
                $"WHERE Category.name = N'{category}'; " +
                $"IF @id_category IS NULL " +
                $"BEGIN " +
                $"INSERT INTO Category (name) " +
                $"VALUES (N'{category}'); " +
                $"SET @id_category = SCOPE_IDENTITY(); " +
                $"END " +
                $"UPDATE Product " +
                $"SET name = N'{productName}', " +
                $"price = {price}, " +
                $"quantity = {quantity}, " +
                $"id_category = @id_category " +
                $"WHERE Product.id = {idProduct};";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
            {
                connection.Open();
                if (connection.State != ConnectionState.Open)
                {
                    FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд", "Ошибка");
                    formErr.ShowDialog();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            if (db.SqlSimpleQuery(query)!=null)
            {
                FormErrorShowDialog form = new FormErrorShowDialog("Продукт успешно обновлен", "Успех");
                form.ShowDialog();
                query = $"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;";
                if (db.SqlReturnData(query, dgvProduct) != null)
                    dgvProduct.Columns[3].Width = 0;
            }
            updateComboBox(cbCategory, "Category");
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = 3;
            txtCategoryNewProduct.Text = "";
            txtPriceNewProduct.Text = "";
            txtProductNameNewProduct.Text = "";
            txtQuantityNewProduct.Text = "";
            cbCategoryNewProduct.Location = new Point(9, 50);
            updateComboBox(cbCategoryNewProduct, "Category");
        }

        private void chkNewCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtCategoryNewProduct.Visible = !txtCategoryNewProduct.Visible;
            cbCategoryNewProduct.Visible = !cbCategoryNewProduct.Visible;
        }

        private void btnDeletePurchase_Click(object sender, EventArgs e)
        {
            if (idPurchase == 0)
            {
                FormErrorShowDialog formError = new FormErrorShowDialog("Не выбран заказ");
                formError.ShowDialog();
                return;
            }
            string query = $"DELETE FROM Purchase WHERE id = {idPurchase};";
            db.SqlSimpleQuery(query);
            idPurchase = 0;
            query = $"SELECT Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id WHERE Purchase.user_id = {IdUser};";
            db.SqlReturnData(query, dgvPurchase);
        }

        private void cbPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            var purchaseProductName = cbPurchase.SelectedItem;
            if (purchaseProductName != null)
            {
                string selectedPurchase = purchaseProductName.ToString();
                string query;
                if (selectedPurchase == "Все")
                {
                    if (Role == "admin")
                        query = $"SELECT Purchase.id AS 'idPurchase', Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.user_id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id;";
                    else
                    {
                        query = $"SELECT Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id WHERE Purchase.user_id = {IdUser};";
                        dgvPurchase.Columns[3].Width = 0;
                    }
                }
                else
                {
                    if (Role == "admin")
                        query = $"SELECT Purchase.id AS 'idPurchase', Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.user_id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id WHERE Product.name = N'{selectedPurchase}'; ";
                    else
                    {
                        query = $"SELECT Product.name AS N'Название', Purchase.quantity AS N'Кол-во', Purchase.price AS N'Стоимость', Purchase.id FROM Product INNER JOIN Purchase ON Product.id = Purchase.product_id WHERE Purchase.user_id = {IdUser} AND Product.name = N'{selectedPurchase}';";
                        dgvPurchase.Columns[3].Width = 0;
                    }
                }

                if (db.SqlReturnData(query, dgvPurchase) != null)
                {
                    dgvPurchase.ColumnHeadersHeight = 50;
                }
            }
        }

        private void btnCancelNewProduct_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = 1;
        }

        private void btnChangePurshase_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            string category;
            string query;
            if (chkNewCategory.Checked)
            {
                category = txtCategoryNewProduct.Text;
                query = $"INSERT INTO Category (name) VALUES (N'{category}')";
                db.SqlSimpleQuery(query);
            }
            else
                category = cbCategoryNewProduct.SelectedItem.ToString();
            query = $"SELECT id FROM Category WHERE name = N'{category}'";
            string newProduct = txtProductNameNewProduct.Text;
            int priceNewProduct = int.Parse(txtPriceNewProduct.Text);
            int quantityNewProduct = int.Parse(txtQuantityNewProduct.Text);
            string answer;
            int idCategory = int.Parse(db.ReturnStringValue(query, out answer));
            query = $"INSERT INTO Product (id_category, name, quantity,price) VALUES ({idCategory}, N'{newProduct}', {quantityNewProduct}, {priceNewProduct})";
            db.SqlSimpleQuery(query);
            guna2TabControl1.SelectedIndex = 1;
            query = "SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;";
            if (db.SqlReturnData(query, dgvProduct) != null)
            {
                dgvProduct.ColumnHeadersHeight = 50;
                dgvProduct.Columns[3].Width = 0;
                FormErrorShowDialog form = new FormErrorShowDialog("Новый товар успешно добавлен", "Успех");
                form.ShowDialog();
            }
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPurchase.Rows[e.RowIndex];

                int columnIndex = dgvPurchase.Columns["idPurchase"].Index;
                idPurchase = Convert.ToInt32(selectedRow.Cells[columnIndex].Value);

                columnIndex = dgvPurchase.Columns["Название"].Index;
                productNamePurchase = selectedRow.Cells[columnIndex].Value.ToString();
                txtNameProductInPurchase.Text = productNamePurchase;
                columnIndex = dgvPurchase.Columns["Кол-во"].Index;
                quantityPurchase = int.Parse(selectedRow.Cells[columnIndex].Value.ToString());
                txtQuantityInPurchase.Text = quantityPurchase.ToString();
                columnIndex = dgvPurchase.Columns["Стоимость"].Index;
                pricePurchase = int.Parse(selectedRow.Cells[columnIndex].Value.ToString());
                txtPriceInPurchase.Text = pricePurchase.ToString();
            }
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            FormErrorShowDialog form;
            if (idProduct == 0)
            {
                form = new FormErrorShowDialog("Не выбран товар", "Ошибка");
                form.ShowDialog();
                return;
            }
            FormMakePuchase formMakePuchase = new FormMakePuchase(idProduct, productName, price, quantity, IdUser);
            formMakePuchase.ShowDialog();
            string query = $"SELECT Product.name AS N'Название', price AS N'Цена', quantity AS N'Кол-во', Product.id FROM Product;";
            db.SqlReturnData(query, dgvProduct);
        }
    }
}