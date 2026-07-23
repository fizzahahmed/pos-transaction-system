using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
namespace WinFormsApp5
{
    public partial class AddItemControl : UserControl
    {
        public event Action<int, string, decimal, byte[]> ItemAdded;

        private byte[] selectedImageBytes = null;
        private string connectionString = "Data Source=MUSSAB\\MSSQLSERVER05;Initial Catalog=product;Integrated Security=True;Trust Server Certificate=True";

        public AddItemControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price entered.");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("INSERT INTO InventoryItems (ItemName, Price, ImageData) VALUES (@name, @price, @image); SELECT SCOPE_IDENTITY();", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = (object?)selectedImageBytes ?? DBNull.Value;

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Raise event to parent
                    ItemAdded?.Invoke(newId, name, price, selectedImageBytes);

                    // Clear form
                    txtName.Text = "";
                    txtPrice.Text = "";
                    pictureBox1.Image = null;
                    selectedImageBytes = null;

                } 
                MessageBox.Show("Item Added Successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete InventoryItems where Itemname=@Itemname", conn);
            cmd.Parameters.AddWithValue("@Itemname", txtName.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Deleted Successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("select * from InventoryItems", conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the item name to update.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price entered.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE InventoryItems SET Price = @Price, ImageData = @ImageData WHERE ItemName = @ItemName", conn);

                cmd.Parameters.AddWithValue("@ItemName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value =
                    (object?)selectedImageBytes ?? DBNull.Value;

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item updated successfully.");
                }
                else
                {
                    MessageBox.Show("Item not found or update failed.");
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


