using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        private byte[] selectedImageBytes = null;
        private void coustum()
        {

        }
        


        string connectionString = "Data Source=MUSSAB\\MSSQLSERVER05;Initial Catalog=product;Integrated Security=True;Trust Server Certificate=True";

        public Form2()
        {
            InitializeComponent();
            LoadItems();
            hompage1.BringToFront();
            addItemControl1.ItemAdded += (id, name, price, imageData) =>
            {
                CreateItemButton(id, name, price, imageData);
            };
        }

        private void LoadItems()
        {
            itemPanelControl1.ClearItems();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, ItemName, Price, ImageData FROM InventoryItems", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        byte[] imageData = reader.IsDBNull(3) ? null : (byte[])reader[3];


                        CreateItemButton(id, name, price, imageData);
                    }
                }
            }
        }

        private void btnAdddItem_Click(object sender, EventArgs e)
        {

        }

        private void CreateItemButton(int id, string name, decimal price, byte[] imageData)
        {
            Image image = null;

            if (imageData != null)
            {
                using (var ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
            }

            var itemControl = new ItemCardControl();
            itemControl.SetItemData(id, name, price, image);

            itemPanelControl1.AddItemButton(itemControl);
            itemControl.ItemClicked += (itemName, itemPrice, quantity) =>
            {
                itemPanelControl1.AddToCart(itemName, itemPrice * quantity, quantity);
            };

            itemPanelControl1.AddItemButton(itemControl);

        }

        private void mtnBrowseImage_Click(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void me_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemPanelControl1.BringToFront();
            LoadItems();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addItemControl1.BringToFront();
            LoadItems();
        }

        private void addItemControl1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hompage1.BringToFront();
        }
    }
}
