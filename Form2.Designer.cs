namespace WinFormsApp5
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            panel1 = new Panel();
            button2 = new Button();
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            itemPanelControl1 = new ItemPanelControl();
            addItemControl1 = new AddItemControl();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            hompage1 = new hompage();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(1, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 364);
            panel1.TabIndex = 54;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Cursor = Cursors.SizeAll;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(0, 78);
            button2.Name = "button2";
            button2.Size = new Size(323, 48);
            button2.TabIndex = 6;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Silver;
            button6.Cursor = Cursors.SizeAll;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.ImageAlign = ContentAlignment.TopLeft;
            button6.Location = new Point(0, 246);
            button6.Name = "button6";
            button6.Size = new Size(323, 48);
            button6.TabIndex = 5;
            button6.Text = "Add Items";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.SizeAll;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(0, 164);
            button1.Name = "button1";
            button1.Size = new Size(323, 48);
            button1.TabIndex = 4;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(440, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 2;
            // 
            // itemPanelControl1
            // 
            itemPanelControl1.Location = new Point(322, 107);
            itemPanelControl1.Name = "itemPanelControl1";
            itemPanelControl1.Size = new Size(1258, 773);
            itemPanelControl1.TabIndex = 56;
            // 
            // addItemControl1
            // 
            addItemControl1.BackColor = Color.White;
            addItemControl1.Location = new Point(322, 107);
            addItemControl1.Name = "addItemControl1";
            addItemControl1.Size = new Size(1266, 793);
            addItemControl1.TabIndex = 57;
            addItemControl1.Load += addItemControl1_Load;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1589, 89);
            panel3.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Edwardian Script ITC", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 71);
            label1.TabIndex = 1;
            label1.Text = "Florence Resturant";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // hompage1
            // 
            hompage1.Location = new Point(330, 107);
            hompage1.Name = "hompage1";
            hompage1.Size = new Size(1258, 793);
            hompage1.TabIndex = 59;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 902);
            Controls.Add(hompage1);
            Controls.Add(panel3);
            Controls.Add(addItemControl1);
            Controls.Add(itemPanelControl1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Resturant POS";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private ItemPanelControl itemPanelControl1;
        private Button button6;
        private AddItemControl addItemControl1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private hompage hompage1;
        private ErrorProvider errorProvider1;
    }
}