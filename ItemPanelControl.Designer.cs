namespace WinFormsApp5
{
    partial class ItemPanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1Item = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtDiscount = new TextBox();
            txtTax = new TextBox();
            lblFinalTotal = new Label();
            lblTotalAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1Item
            // 
            flowLayoutPanel1Item.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel1Item.Location = new Point(0, 0);
            flowLayoutPanel1Item.Name = "flowLayoutPanel1Item";
            flowLayoutPanel1Item.Size = new Size(745, 818);
            flowLayoutPanel1Item.TabIndex = 0;
            flowLayoutPanel1Item.Paint += flowLayoutPanel1Item_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Price, Quantity, Total });
            dataGridView1.Location = new Point(751, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 818);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Visible = false;
            Total.Width = 125;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(1005, 637);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 34);
            txtDiscount.TabIndex = 2;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(1005, 556);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(125, 34);
            txtTax.TabIndex = 3;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.BackColor = SystemColors.ControlDark;
            lblFinalTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalTotal.Location = new Point(905, 727);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(125, 38);
            lblFinalTotal.TabIndex = 4;
            lblFinalTotal.Text = "Amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = SystemColors.ControlDark;
            lblTotalAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(1005, 463);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(125, 38);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(797, 546);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 6;
            label1.Text = "Tax%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(763, 627);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 7;
            label2.Text = "Discount%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(763, 721);
            label3.Name = "label3";
            label3.Size = new Size(99, 46);
            label3.TabIndex = 8;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(763, 457);
            label4.Name = "label4";
            label4.Size = new Size(169, 46);
            label4.TabIndex = 9;
            label4.Text = "Sub Total";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ActiveCaptionText;
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(1060, 736);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print Bill";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // ItemPanelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblFinalTotal);
            Controls.Add(txtTax);
            Controls.Add(txtDiscount);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1Item);
            Name = "ItemPanelControl";
            Size = new Size(1172, 833);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1Item;
        private DataGridView dataGridView1;
        private TextBox txtDiscount;
        private TextBox txtTax;
        private Label lblFinalTotal;
        private Label lblTotalAmount;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPrint;
    }
}
