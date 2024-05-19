namespace Modul4
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReadOne = new Button();
            txtId = new TextBox();
            lblId = new Label();
            txtNameFilter = new TextBox();
            txtMinPriceFilter = new TextBox();
            txtMaxPriceFilter = new TextBox();
            txtMinStockFilter = new TextBox();
            txtMaxStockFilter = new TextBox();
            btnFilter = new Button();
            lblNameFilter = new Label();
            lblMinPriceFilter = new Label();
            lblMaxPriceFilter = new Label();
            lblMinStockFilter = new Label();
            lblMaxStockFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(600, 300);
            dataGridView.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(627, 122);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 39);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(627, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 39);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(627, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 39);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReadOne
            // 
            btnReadOne.Location = new Point(627, 73);
            btnReadOne.Name = "btnReadOne";
            btnReadOne.Size = new Size(75, 30);
            btnReadOne.TabIndex = 4;
            btnReadOne.Text = "Read One";
            btnReadOne.UseVisualStyleBackColor = true;
            btnReadOne.Click += btnReadOne_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(627, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 5;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(627, 12);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 6;
            lblId.Text = "ID";
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(30, 345);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(100, 27);
            txtNameFilter.TabIndex = 7;
            // 
            // txtMinPriceFilter
            // 
            txtMinPriceFilter.Location = new Point(144, 345);
            txtMinPriceFilter.Name = "txtMinPriceFilter";
            txtMinPriceFilter.Size = new Size(100, 27);
            txtMinPriceFilter.TabIndex = 8;
            // 
            // txtMaxPriceFilter
            // 
            txtMaxPriceFilter.Location = new Point(261, 345);
            txtMaxPriceFilter.Name = "txtMaxPriceFilter";
            txtMaxPriceFilter.Size = new Size(100, 27);
            txtMaxPriceFilter.TabIndex = 9;
            // 
            // txtMinStockFilter
            // 
            txtMinStockFilter.Location = new Point(376, 345);
            txtMinStockFilter.Name = "txtMinStockFilter";
            txtMinStockFilter.Size = new Size(100, 27);
            txtMinStockFilter.TabIndex = 10;
            // 
            // txtMaxStockFilter
            // 
            txtMaxStockFilter.Location = new Point(496, 345);
            txtMaxStockFilter.Name = "txtMaxStockFilter";
            txtMaxStockFilter.Size = new Size(100, 27);
            txtMaxStockFilter.TabIndex = 11;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(627, 342);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 30);
            btnFilter.TabIndex = 12;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblNameFilter
            // 
            lblNameFilter.AutoSize = true;
            lblNameFilter.Location = new Point(30, 329);
            lblNameFilter.Name = "lblNameFilter";
            lblNameFilter.Size = new Size(49, 20);
            lblNameFilter.TabIndex = 13;
            lblNameFilter.Text = "Name";
            // 
            // lblMinPriceFilter
            // 
            lblMinPriceFilter.AutoSize = true;
            lblMinPriceFilter.Location = new Point(141, 329);
            lblMinPriceFilter.Name = "lblMinPriceFilter";
            lblMinPriceFilter.Size = new Size(70, 20);
            lblMinPriceFilter.TabIndex = 14;
            lblMinPriceFilter.Text = "Min Price";
            // 
            // lblMaxPriceFilter
            // 
            lblMaxPriceFilter.AutoSize = true;
            lblMaxPriceFilter.Location = new Point(258, 329);
            lblMaxPriceFilter.Name = "lblMaxPriceFilter";
            lblMaxPriceFilter.Size = new Size(73, 20);
            lblMaxPriceFilter.TabIndex = 15;
            lblMaxPriceFilter.Text = "Max Price";
            // 
            // lblMinStockFilter
            // 
            lblMinStockFilter.AutoSize = true;
            lblMinStockFilter.Location = new Point(373, 329);
            lblMinStockFilter.Name = "lblMinStockFilter";
            lblMinStockFilter.Size = new Size(74, 20);
            lblMinStockFilter.TabIndex = 16;
            lblMinStockFilter.Text = "Min Stock";
            // 
            // lblMaxStockFilter
            // 
            lblMaxStockFilter.AutoSize = true;
            lblMaxStockFilter.Location = new Point(493, 329);
            lblMaxStockFilter.Name = "lblMaxStockFilter";
            lblMaxStockFilter.Size = new Size(77, 20);
            lblMaxStockFilter.TabIndex = 17;
            lblMaxStockFilter.Text = "Max Stock";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 393);
            Controls.Add(lblMaxStockFilter);
            Controls.Add(lblMinStockFilter);
            Controls.Add(lblMaxPriceFilter);
            Controls.Add(lblMinPriceFilter);
            Controls.Add(lblNameFilter);
            Controls.Add(btnFilter);
            Controls.Add(txtMaxStockFilter);
            Controls.Add(txtMinStockFilter);
            Controls.Add(txtMaxPriceFilter);
            Controls.Add(txtMinPriceFilter);
            Controls.Add(txtNameFilter);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnReadOne);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReadOne;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtNameFilter;
        private TextBox txtMinPriceFilter;
        private TextBox txtMaxPriceFilter;
        private TextBox txtMinStockFilter;
        private TextBox txtMaxStockFilter;
        private Button btnFilter;
        private Label lblNameFilter;
        private Label lblMinPriceFilter;
        private Label lblMaxPriceFilter;
        private Label lblMinStockFilter;
        private Label lblMaxStockFilter;

        #endregion
    }
}