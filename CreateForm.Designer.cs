namespace Modul4
{
    partial class CreateForm
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Button();
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 28);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(413, 27);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(122, 70);
            txtPrice.Margin = new Padding(2, 2, 2, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(413, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(122, 112);
            txtStock.Margin = new Padding(2, 2, 2, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(413, 27);
            txtStock.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(459, 166);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 30);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(27, 75);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(27, 117);
            lblStock.Margin = new Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 222);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateForm";
            Text = "Create Product";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnSave;
        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        #endregion
    }
}