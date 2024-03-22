namespace Practika
{
    partial class FormMakePuchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.iBtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMakePurchase = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.nudQunatityProduct = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblMakePurchase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQunatityProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.iBtnClose.Location = new System.Drawing.Point(687, 2);
            this.iBtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnClose.Name = "iBtnClose";
            this.iBtnClose.Size = new System.Drawing.Size(37, 41);
            this.iBtnClose.TabIndex = 3;
            this.iBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnClose.UseVisualStyleBackColor = true;
            this.iBtnClose.Click += new System.EventHandler(this.iBtnClose_Click);
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.BorderRadius = 20;
            this.btnMakePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakePurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMakePurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMakePurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMakePurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMakePurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMakePurchase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePurchase.ForeColor = System.Drawing.Color.White;
            this.btnMakePurchase.Location = new System.Drawing.Point(142, 264);
            this.btnMakePurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.Size = new System.Drawing.Size(195, 55);
            this.btnMakePurchase.TabIndex = 6;
            this.btnMakePurchase.Text = "Ок";
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(419, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 55);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudQunatityProduct
            // 
            this.nudQunatityProduct.BackColor = System.Drawing.Color.Transparent;
            this.nudQunatityProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudQunatityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQunatityProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.nudQunatityProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudQunatityProduct.ForeColor = System.Drawing.Color.White;
            this.nudQunatityProduct.Location = new System.Drawing.Point(452, 133);
            this.nudQunatityProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQunatityProduct.Name = "nudQunatityProduct";
            this.nudQunatityProduct.Size = new System.Drawing.Size(241, 48);
            this.nudQunatityProduct.TabIndex = 8;
            this.nudQunatityProduct.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(53, 133);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(27, 38);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "f";
            // 
            // lblMakePurchase
            // 
            this.lblMakePurchase.AutoSize = true;
            this.lblMakePurchase.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMakePurchase.ForeColor = System.Drawing.Color.White;
            this.lblMakePurchase.Location = new System.Drawing.Point(28, 28);
            this.lblMakePurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakePurchase.Name = "lblMakePurchase";
            this.lblMakePurchase.Size = new System.Drawing.Size(222, 41);
            this.lblMakePurchase.TabIndex = 9;
            this.lblMakePurchase.Text = "Сделать заказ";
            // 
            // FormMakePuchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(730, 373);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblMakePurchase);
            this.Controls.Add(this.nudQunatityProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakePurchase);
            this.Controls.Add(this.iBtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMakePuchase";
            this.Text = "FormMakePuchase";
            this.Load += new System.EventHandler(this.FormMakePuchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQunatityProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton iBtnClose;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnMakePurchase;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQunatityProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblMakePurchase;
    }
}