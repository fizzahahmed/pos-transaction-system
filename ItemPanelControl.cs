using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class ItemPanelControl : UserControl
    {
        private PrintDocument printDocument = new PrintDocument();
        private int currentRowIndex = 0;
        private float yPos;

        public ItemPanelControl()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        public void AddItemButton(Control control)
        {
            flowLayoutPanel1Item.Controls.Add(control);
        }

        public void ClearItems()
        {
            flowLayoutPanel1Item.Controls.Clear();
        }
        private void flowLayoutPanel1Item_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ItemPanelControl_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Total", "Total");

           
           
        }
        public void AddToCart(string name, decimal price, int qty)
        {
            decimal total = price * qty;
            dataGridView1.Rows.Add(name, price, qty, total);

        }
        public void UpdateTotalAmount()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    grandTotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            lblTotalAmount.Text = $" ${grandTotal:F2}";

            // Get discount and tax percentages
            decimal discountPercent = 0, taxPercent = 0;
            decimal.TryParse(txtDiscount.Text, out discountPercent);
            decimal.TryParse(txtTax.Text, out taxPercent);

            // Apply discount
            decimal discountAmount = grandTotal * (discountPercent / 100);
            decimal afterDiscount = grandTotal - discountAmount;

            // Apply tax
            decimal taxAmount = afterDiscount * (taxPercent / 100);
            decimal finalTotal = afterDiscount + taxAmount;

            lblFinalTotal.Text = $" ${finalTotal:F2}";
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            float lineHeight = bodyFont.GetHeight(e.Graphics) + 4;
            float x = 50;
            float y = 50;

            // Title
            e.Graphics.DrawString("Invoice / Bill", headerFont, Brushes.Black, x, y);
            y += 40;

            // Column headers
            e.Graphics.DrawString("Product", subHeaderFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Price", subHeaderFont, Brushes.Black, x + 200, y);
            e.Graphics.DrawString("Qty", subHeaderFont, Brushes.Black, x + 300, y);
            e.Graphics.DrawString("Total", subHeaderFont, Brushes.Black, x + 400, y);
            y += lineHeight;

            decimal subTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["ProductName"].Value?.ToString();
                string price = row.Cells["Price"].Value?.ToString();
                string qty = row.Cells["Quantity"].Value?.ToString();
                string total = row.Cells["Total"].Value?.ToString();

                subTotal += Convert.ToDecimal(total);

                e.Graphics.DrawString(name, bodyFont, Brushes.Black, x, y);
                e.Graphics.DrawString(price, bodyFont, Brushes.Black, x + 200, y);
                e.Graphics.DrawString(qty, bodyFont, Brushes.Black, x + 300, y);
                e.Graphics.DrawString(total, bodyFont, Brushes.Black, x + 400, y);
                y += lineHeight;
            }

            y += 20;

            // Discount and Tax
            decimal.TryParse(txtDiscount.Text, out decimal discountPercent);
            decimal.TryParse(txtTax.Text, out decimal taxPercent);

            decimal discountAmount = subTotal * (discountPercent / 100);
            decimal afterDiscount = subTotal - discountAmount;
            decimal taxAmount = afterDiscount * (taxPercent / 100);
            decimal finalTotal = afterDiscount + taxAmount;

            // Totals
            e.Graphics.DrawString($"Subtotal: ${subTotal:F2}", bodyFont, Brushes.Black, x, y); y += lineHeight;
            e.Graphics.DrawString($"Discount ({discountPercent}%): -${discountAmount:F2}", bodyFont, Brushes.Black, x, y); y += lineHeight;
            e.Graphics.DrawString($"Tax ({taxPercent}%): +${taxAmount:F2}", bodyFont, Brushes.Black, x, y); y += lineHeight;
            e.Graphics.DrawString($"Final Total: ${finalTotal:F2}", subHeaderFont, Brushes.Black, x, y); y += lineHeight;

            // Optional: thank you footer
            y += 30;
            e.Graphics.DrawString("Thank you for your purchase!", bodyFont, Brushes.Black, x, y);
        }



    }

}
