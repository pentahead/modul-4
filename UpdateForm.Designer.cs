namespace Modul4
{
    partial class UpdateForm
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Button();
            lblId = new Label();
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 27);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(407, 27);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 65);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 27);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(113, 104);
            txtPrice.Margin = new Padding(2, 2, 2, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(407, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(113, 143);
            txtStock.Margin = new Padding(2, 2, 2, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(407, 27);
            txtStock.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(442, 194);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(38, 27);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 62);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(36, 106);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(38, 146);
            lblStock.Margin = new Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 243);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateForm";
            Text = "Update Product";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnSave;
        private Label lblId;
        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        #endregion
    }
}