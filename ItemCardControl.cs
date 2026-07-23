using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class ItemCardControl : UserControl
    {
        public int ItemId { get; set; }

        public event Action< string, decimal, int> ItemClicked;


        public ItemCardControl()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width = 300;
            this.Height = 180;

        }

        public void SetItemData(int id, string name, decimal price, Image image)
        {
            this.ItemId = id;

            // Price Label
            Label lblPrice = new Label
            {
                Text = $"${price:F2}",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.OrangeRed,
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(lblPrice);

            // QTY Label
            Label lblQty = new Label
            {
                Text = "QTY",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 50),
                AutoSize = true
            };
            this.Controls.Add(lblQty);

            // QTY TextBox
            TextBox txtQty = new TextBox
            {                Width = 40,
                Location = new Point(60, 50)
            };
            this.Controls.Add(txtQty);

            // PictureBox
            PictureBox picture = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(180, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image
            };
            this.Controls.Add(picture);

            // Name Label
            Label lblName = new Label
            {
                Text = name,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = false,
                Width = this.Width,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 120)
            };
            this.Controls.Add(lblName);
            Button btnAdd = new Button
            {
                Text = "Add to Cart",
                Location = new Point(12, 90),
                Width = 100,
                Height = 30
            };
            btnAdd.Click += (s, e) =>
            {
                int qty = 1;
                int.TryParse(txtQty.Text, out qty);
                if (qty <= 0) qty = 1;

                ItemClicked?.Invoke(name, price, qty);
            };
            this.Controls.Add(btnAdd);
        }


    }
    }

