using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_ILS2
{
    public partial class Form1 : Form
    {
        //Products na naka register sa program natin
        string[,] Products = new string[,] {
                { "100012", "Supreme Cookies and Cream 2L", "2 Liter", "350.00", "1", "350.00" },
                { "100024", "Alfonso I Light Alcohol", "1 Liter", "284.00", "1", "284.00" },
                { "100036", "Nido Junior Advanced", "2.4 Kg", "1344.00", "1", "1344.00" },
                { "100048", "JACK & JILL PIATTOS", "170G", "28.00", "1", "28.00" },
                { "100060", "PEPSI REG", "2L", "78.00", "1", "78.00" },
                { "100072", "555 TUNA AFRITADA", "155G", "30.00", "1", "30.00" },
                { "100084", "NESCAFE TWINPCK", "56GX5", "64.00", "1", "64.00" },
                { "100096", "CENTURY TUNA FLAKES VEG OIL", "180G", "42.00", "1", "42.00" },
                { "1000108", "LADYS CHOICE MAYO DOY", "220ML", "89.00", "1", "89.00" },
                { "1000120", "NESTLE COFFEEMATE", "450G", "110.00", "1", "110.00" },
                { "1000132", "HERMANO SUGAR REFINED", "1KG", "94.00", "1", "94.00" },
                { "1000144", "STICK O MINI CHOC WAFER", "60G", "21.00", "1", "21.00" },
                { "1000157", "GOLDEN CROWN BUTTER", "225GM", "56.00", "1", "56.00" },
                { "1000168", "CALI SPARKLING PINEAPPLE", "330ML", "35.00", "1", "35.00" },
                { "1000180", "HAPPY DIAPER", "XLARGE 30S", "224.00", "1", "224.00" },
                { "1000192", "ALASKA CONDENSED MILK", "168ML", " 40.00", "1", " 40.00" },
                { "1000204", "MILO ACTIGEN E HIGH MALT", "300G", "95.00", "1", "95.00" },
                { "1000216", "GOYA CHOCO HAZELNUT", "400G", "172.00", "1", "172.00" }
            };
        double _subTotal, _totalAmount;
        string barcode;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = tb_barcode;
        }

        //function nung add button sa barcode
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            barcode = tb_barcode.Text;
            bool hasDuplicate = false; //variable po para sa status if may duplicate product sa table
            for (int i = 0; i < Products.GetLength(0); i++)
            {
                if (barcode == Products[i, 0]) //dito po chine check if yung barcode na ininput sa textbox is registered sa system
                {
                    if (receiptTable.Rows.Count > 0) //chine check po dito if may laman na yung table kapag may laman na po mag proceed siya sa duplicate checking
                    {
                        foreach (DataGridViewRow row in receiptTable.Rows) //duplicate checking
                        {
                            if (Convert.ToString(row.Cells[0].Value) == barcode) //chine check po kung meron ng naka record sa table na same barcode ng tina try iadd sa receipt
                            {
                                int qty = Convert.ToInt16(row.Cells[4].Value.ToString()); //kinonvert po to int yung value ng quantity sa row na nakitaan ng duplicate
                                qty++; //nag add po ng +1 dun sa qty variable
                                row.Cells[4].Value = Convert.ToString(qty); //dito po nagset ng new qty value nung row na may duplicate
                                hasDuplicate = true; //yung hasDuplicate po ginawang true kasi nakitaan ng duplicate sa table
                            }
                        }
                        if (!hasDuplicate) //mae execute po kapag nag false yung duplicate checking sa taas
                        {
                            receiptTable.Rows.Add(Products[i, 0], Products[i, 1], Products[i, 2], Products[i, 3], Products[i, 4], Products[i, 5]);
                        }
                    }
                    else //mae execute po kapag empty pa yung table (could be first time po mag add so skip na ng check para mas mabilis)
                    {
                        receiptTable.Rows.Add(Products[i, 0], Products[i, 1], Products[i, 2], Products[i, 3], Products[i, 4], Products[i, 5]);
                    }
                    statusText.Text = "Product successfully added.";
                    statusText.ForeColor = Color.Green;

                    break;
                }
                else
                {
                    statusText.Text = "Cannot find the product.";
                    statusText.ForeColor = Color.Red;
                }
            }
            updateSummary(); //calls updateSummary function po everytime na magclick ng add button para ma update yung Summary section ng program
            tb_barcode.Text = string.Empty;
        }

        private void editCell_Click(object sender, EventArgs e) //edit button function po
        {
            if (receiptTable.SelectedCells.Count > 0) //check po kung may selected na cell sa table si user
            { //if mag true, nae enable po yung textbox at button para sa edit function
                editPaneStatus(true); 
                foreach (DataGridViewCell cell in receiptTable.SelectedCells)
                {
                    tb_editValue.Text = cell.Value.ToString();
                    statusText.Text = "Editing the " + cell.OwningColumn.HeaderText + " in row " + (cell.OwningRow.Index + 1);
                    statusText.ForeColor = Color.Green;
                }
            }
            else
            { //if mag false, mag display ng simple error text
                editPaneStatus(false);
                statusText.Text = "No cell is selected";
                statusText.ForeColor = Color.Red;
            }
        }

        private void editPaneStatus(bool status) //function po para magset ng status ng edit part ng program
        {
            tb_editValue.Enabled = status;
            btn_saveEdit.Enabled = status;
            tb_editValue.Text = string.Empty;
        }

        private void btn_saveEdit_Click(object sender, EventArgs e) 
        { //ise save po sa table yung value na inedit na nilagay ng user
            string newValue = tb_editValue.Text;
            foreach (DataGridViewCell cell in receiptTable.SelectedCells)
            {
                cell.Value = newValue;
            }
            editPaneStatus(false);
            updateSummary();
        }

        private void tb_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) //nag add ng function po sa Enter key sa keyboard para di na need lagi gamitin mouse pang click sa Add button
            {
                btn_addProduct_Click(sender, e);
            }
            else //if any key po pinindot mag rereset to blank lang po yung statusText para hindi maiwan yung error or product added na text
            {
                statusText.Text = "";
            }
        }

        private void updateSummary() //function responsible po sa pag update ng Summary section ng program
        { //(sub total, vat, discount, final price)
            updateTotalPrices();
            double totalPriceHolder = 0;
            double[] pricesToAdd;
            for (int i = 0; i < receiptTable.Rows.Count; i++) //pinag-a-add po lahat ng total product price para mabuo yung final overall price
            {
                pricesToAdd = new double[receiptTable.Rows.Count];
                pricesToAdd[i] = double.Parse(receiptTable.Rows[i].Cells[5].Value.ToString());
                for (int j = 0; j < pricesToAdd.Length; j++)
                {
                    totalPriceHolder += pricesToAdd[j];
                }
            }
            _subTotal = totalPriceHolder;
            totalPriceHolder = 0;
            subTotal.Text = "₱" + _subTotal.ToString("N2");
            if (cb_discount.Checked)
            {
                calculateTotalAmount(true, _subTotal);
            }
            else
            {
                calculateTotalAmount(false, _subTotal);
            }
        }

        private void calculateTotalAmount(bool isDiscounted, double subTotal) //function po sa pag compute ng final price
        { 
            double _discountPct = Convert.ToDouble(discountPct.Text);
            double _lessVAT = Convert.ToDouble(lessVAT.Text);
            double _discountPrice, _vatTotal;
            if (isDiscounted) //nagche check po if naka check yung discounted checkbox and kung ilang percent po yung discount
            {
                _discountPrice = (subTotal * _discountPct) / 100;
                _vatTotal = (subTotal * _lessVAT) / 100;
                _totalAmount = subTotal + _vatTotal - _discountPrice;
                totalAmount.Text = "₱" + _totalAmount.ToString("N2");
                txt_discountP.Text = "₱" + _discountPrice.ToString("N2");
                txtVat.Text = "₱" + _vatTotal.ToString("N2");
            }
            else
            {
                _vatTotal = (subTotal * _lessVAT) / 100;
                _totalAmount = subTotal + _vatTotal;
                totalAmount.Text = "₱" + _totalAmount.ToString("N2");
                txt_discountP.Text = "₱" + "0.00";
                txtVat.Text = "₱" + _vatTotal.ToString("N2");
            }
        }

        private void updateTotalPrices() //minu multiply po yung price ng product sa quantity para makuha yung total price nung product if more than 1 yung inorder
        {
            foreach (DataGridViewRow row in receiptTable.Rows)
            {
                int qty = Convert.ToInt16(row.Cells[4].Value);
                double price = Convert.ToDouble(row.Cells[3].Value);
                double finalPrice = price * qty;
                row.Cells[5].Value = finalPrice.ToString("N2");
            }
        }

        private void cb_discount_CheckedChanged(object sender, EventArgs e)
        {
            updateSummary();
        }

        private void discountPct_TextChanged(object sender, EventArgs e)
        {
            if (discountPct.Text == string.Empty)
            {
                discountPct.Text = "0";
            }
            updateSummary();
        }

        private void btn_print_Click(object sender, EventArgs e) //function para po sa pagsave or export ng table to Excel file po
        {
            SaveFileDialog sfd = new SaveFileDialog(); //para makapili po ng pagse save-an yung user
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = "Receipt.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var outputFile = new FileInfo(sfd.FileName);
                var templateFile = new FileInfo("template.xlsx"); //just blank excel template file po
                try
                {
                    using (FastExcel.FastExcel fastExcel = new FastExcel.FastExcel(templateFile, outputFile)) //FastExcel po gamit na library for excel file writing
                    {
                        List<ReceiptContent> receipt = new List<ReceiptContent>();


                        for (int rowNumber = 0; rowNumber < receiptTable.Rows.Count; rowNumber++)
                        {
                            ReceiptContent receiptData = new ReceiptContent();
                            receiptData.Barcode = receiptTable.Rows[rowNumber].Cells[0].Value.ToString();
                            receiptData.ProductName = receiptTable.Rows[rowNumber].Cells[1].Value.ToString();
                            receiptData.ProductDescription = receiptTable.Rows[rowNumber].Cells[2].Value.ToString();
                            receiptData.ProductPrice = receiptTable.Rows[rowNumber].Cells[3].Value.ToString();
                            receiptData.Qty = receiptTable.Rows[rowNumber].Cells[4].Value.ToString();
                            receiptData.ProductTotalPrice = receiptTable.Rows[rowNumber].Cells[5].Value.ToString();
                            receiptData.VAT = txtVat.Text;
                            receiptData.discountPct = txt_discountP.Text;
                            receiptData.TotalPrice = totalAmount.Text;

                            receipt.Add(receiptData);
                        }
                        fastExcel.Write(receipt, "Sheet1", true);

                    }
                }catch(Exception)
                {
                    MessageBox.Show("Something went wrong (maybe file already exists)");
                }
            }
        }

        private void btn_newreceipt_Click(object sender, EventArgs e) //clear ng row po para makapag start ulit ng bagong table
        {
            receiptTable.Rows.Clear();
            receiptTable.Refresh();
            updateSummary();
        }
    }

    public class ReceiptContent //class po na nagho hold ng content ng receipt or table
    {
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string Qty { get; set; }
        public string ProductTotalPrice { get; set; }
        public string VAT { get; set; }
        public string discountPct { get; set; }
        public string TotalPrice { get; set; }


    }
}
