namespace Practika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnWindowMax = new FontAwesome.Sharp.IconButton();
            this.iBtnClose = new FontAwesome.Sharp.IconButton();
            this.iBtnWindowMin = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iBtnExit = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.iBtnBasket = new FontAwesome.Sharp.IconButton();
            this.panelLeft3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.panelLeft2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iBtnHome = new FontAwesome.Sharp.IconButton();
            this.panelLeft1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.iBtnWindowMax);
            this.panel1.Controls.Add(this.iBtnClose);
            this.panel1.Controls.Add(this.iBtnWindowMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // iBtnWindowMax
            // 
            this.iBtnWindowMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnWindowMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnWindowMax.FlatAppearance.BorderSize = 0;
            this.iBtnWindowMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnWindowMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnWindowMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnWindowMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iBtnWindowMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnWindowMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnWindowMax.IconSize = 35;
            this.iBtnWindowMax.Location = new System.Drawing.Point(1372, 4);
            this.iBtnWindowMax.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnWindowMax.Name = "iBtnWindowMax";
            this.iBtnWindowMax.Size = new System.Drawing.Size(37, 41);
            this.iBtnWindowMax.TabIndex = 4;
            this.iBtnWindowMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnWindowMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnWindowMax.UseVisualStyleBackColor = true;
            this.iBtnWindowMax.Click += new System.EventHandler(this.iBtnWindowMax_Click);
            // 
            // iBtnClose
            // 
            this.iBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnClose.FlatAppearance.BorderSize = 0;
            this.iBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iBtnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnClose.IconSize = 35;
            this.iBtnClose.Location = new System.Drawing.Point(1417, 4);
            this.iBtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnClose.Name = "iBtnClose";
            this.iBtnClose.Size = new System.Drawing.Size(37, 41);
            this.iBtnClose.TabIndex = 2;
            this.iBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnClose.UseVisualStyleBackColor = true;
            this.iBtnClose.Click += new System.EventHandler(this.iBtnClose_Click);
            // 
            // iBtnWindowMin
            // 
            this.iBtnWindowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnWindowMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnWindowMin.FlatAppearance.BorderSize = 0;
            this.iBtnWindowMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnWindowMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnWindowMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnWindowMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iBtnWindowMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnWindowMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnWindowMin.IconSize = 35;
            this.iBtnWindowMin.Location = new System.Drawing.Point(1323, 4);
            this.iBtnWindowMin.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnWindowMin.Name = "iBtnWindowMin";
            this.iBtnWindowMin.Size = new System.Drawing.Size(37, 41);
            this.iBtnWindowMin.TabIndex = 3;
            this.iBtnWindowMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnWindowMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnWindowMin.UseVisualStyleBackColor = true;
            this.iBtnWindowMin.Click += new System.EventHandler(this.iBtnWindowMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 874);
            this.panel2.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.iBtnExit);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 779);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(292, 95);
            this.panel12.TabIndex = 4;
            // 
            // iBtnExit
            // 
            this.iBtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnExit.FlatAppearance.BorderSize = 0;
            this.iBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iBtnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnExit.IconSize = 40;
            this.iBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnExit.Location = new System.Drawing.Point(0, 0);
            this.iBtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnExit.Name = "iBtnExit";
            this.iBtnExit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iBtnExit.Size = new System.Drawing.Size(292, 95);
            this.iBtnExit.TabIndex = 1;
            this.iBtnExit.Text = "Выход";
            this.iBtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnExit.UseVisualStyleBackColor = true;
            this.iBtnExit.Click += new System.EventHandler(this.iBtnExit_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.iBtnBasket);
            this.panel10.Controls.Add(this.panelLeft3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 377);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(292, 95);
            this.panel10.TabIndex = 3;
            // 
            // iBtnBasket
            // 
            this.iBtnBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnBasket.FlatAppearance.BorderSize = 0;
            this.iBtnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBasket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnBasket.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.iBtnBasket.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnBasket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBasket.IconSize = 40;
            this.iBtnBasket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnBasket.Location = new System.Drawing.Point(11, 0);
            this.iBtnBasket.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnBasket.Name = "iBtnBasket";
            this.iBtnBasket.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnBasket.Size = new System.Drawing.Size(281, 95);
            this.iBtnBasket.TabIndex = 1;
            this.iBtnBasket.Text = "Заказы";
            this.iBtnBasket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnBasket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBasket.UseVisualStyleBackColor = true;
            this.iBtnBasket.Click += new System.EventHandler(this.iBtnBasket_Click);
            // 
            // panelLeft3
            // 
            this.panelLeft3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft3.Location = new System.Drawing.Point(0, 0);
            this.panelLeft3.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft3.Name = "panelLeft3";
            this.panelLeft3.Size = new System.Drawing.Size(11, 95);
            this.panelLeft3.TabIndex = 0;
            this.panelLeft3.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.iBtnSearch);
            this.panel8.Controls.Add(this.panelLeft2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 282);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 95);
            this.panel8.TabIndex = 2;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnSearch.FlatAppearance.BorderSize = 0;
            this.iBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iBtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 40;
            this.iBtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSearch.Location = new System.Drawing.Point(11, 0);
            this.iBtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnSearch.Size = new System.Drawing.Size(281, 95);
            this.iBtnSearch.TabIndex = 1;
            this.iBtnSearch.Text = "Поиск";
            this.iBtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // panelLeft2
            // 
            this.panelLeft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft2.Location = new System.Drawing.Point(0, 0);
            this.panelLeft2.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft2.Name = "panelLeft2";
            this.panelLeft2.Size = new System.Drawing.Size(11, 95);
            this.panelLeft2.TabIndex = 0;
            this.panelLeft2.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iBtnHome);
            this.panel6.Controls.Add(this.panelLeft1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 187);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 95);
            this.panel6.TabIndex = 1;
            // 
            // iBtnHome
            // 
            this.iBtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.iBtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnHome.FlatAppearance.BorderSize = 0;
            this.iBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.iBtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iBtnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.iBtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnHome.IconSize = 40;
            this.iBtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnHome.Location = new System.Drawing.Point(11, 0);
            this.iBtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnHome.Name = "iBtnHome";
            this.iBtnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnHome.Size = new System.Drawing.Size(281, 95);
            this.iBtnHome.TabIndex = 1;
            this.iBtnHome.Text = "Главная";
            this.iBtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnHome.UseVisualStyleBackColor = false;
            this.iBtnHome.Click += new System.EventHandler(this.iBtnHome_Click);
            // 
            // panelLeft1
            // 
            this.panelLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft1.Location = new System.Drawing.Point(0, 0);
            this.panelLeft1.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft1.Name = "panelLeft1";
            this.panelLeft1.Size = new System.Drawing.Size(11, 95);
            this.panelLeft1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 187);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ferma";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.guna2TabControl1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(292, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 874);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1179, 48);
            this.panel5.TabIndex = 0;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(155, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(4, 47);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1171, 814);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(155, 40);
            this.guna2TabControl1.TabIndex = 6;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1163, 766);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1163, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1163, 766);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 923);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iBtnHome;
        private System.Windows.Forms.Panel panelLeft1;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.Panel panelLeft2;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton iBtnExit;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton iBtnBasket;
        private System.Windows.Forms.Panel panelLeft3;
        private FontAwesome.Sharp.IconButton iBtnClose;
        private FontAwesome.Sharp.IconButton iBtnWindowMax;
        private FontAwesome.Sharp.IconButton iBtnWindowMin;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

