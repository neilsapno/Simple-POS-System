namespace POS_ILS2
{
    partial class Form1
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
            this.receiptTable = new System.Windows.Forms.DataGridView();
            this.c_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_pricePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_discount = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveEdit = new System.Windows.Forms.Button();
            this.tb_editValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_newreceipt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.f2edit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.txt_discountP = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.discountPct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lessVAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transaction_id = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiptTable
            // 
            this.receiptTable.AllowUserToAddRows = false;
            this.receiptTable.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.receiptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_barcode,
            this.c_prodName,
            this.c_ProdDesc,
            this.c_pricePer,
            this.c_qty,
            this.c_totalPrice});
            this.receiptTable.GridColor = System.Drawing.Color.Black;
            this.receiptTable.Location = new System.Drawing.Point(12, 98);
            this.receiptTable.MultiSelect = false;
            this.receiptTable.Name = "receiptTable";
            this.receiptTable.ReadOnly = true;
            this.receiptTable.RowHeadersVisible = false;
            this.receiptTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.receiptTable.RowTemplate.DividerHeight = 1;
            this.receiptTable.RowTemplate.Height = 30;
            this.receiptTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.receiptTable.Size = new System.Drawing.Size(873, 439);
            this.receiptTable.TabIndex = 14;
            // 
            // c_barcode
            // 
            this.c_barcode.HeaderText = "Barcode";
            this.c_barcode.MinimumWidth = 80;
            this.c_barcode.Name = "c_barcode";
            this.c_barcode.ReadOnly = true;
            this.c_barcode.Width = 110;
            // 
            // c_prodName
            // 
            this.c_prodName.HeaderText = "Product Name";
            this.c_prodName.MinimumWidth = 150;
            this.c_prodName.Name = "c_prodName";
            this.c_prodName.ReadOnly = true;
            this.c_prodName.Width = 180;
            // 
            // c_ProdDesc
            // 
            this.c_ProdDesc.HeaderText = "Description";
            this.c_ProdDesc.MinimumWidth = 120;
            this.c_ProdDesc.Name = "c_ProdDesc";
            this.c_ProdDesc.ReadOnly = true;
            this.c_ProdDesc.Width = 160;
            // 
            // c_pricePer
            // 
            this.c_pricePer.HeaderText = "Price";
            this.c_pricePer.MinimumWidth = 80;
            this.c_pricePer.Name = "c_pricePer";
            this.c_pricePer.ReadOnly = true;
            // 
            // c_qty
            // 
            this.c_qty.HeaderText = "Qty";
            this.c_qty.MinimumWidth = 60;
            this.c_qty.Name = "c_qty";
            this.c_qty.ReadOnly = true;
            this.c_qty.Width = 80;
            // 
            // c_totalPrice
            // 
            this.c_totalPrice.HeaderText = "Total";
            this.c_totalPrice.MinimumWidth = 100;
            this.c_totalPrice.Name = "c_totalPrice";
            this.c_totalPrice.ReadOnly = true;
            this.c_totalPrice.Width = 120;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addProduct.Location = new System.Drawing.Point(708, 46);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(75, 36);
            this.btn_addProduct.TabIndex = 13;
            this.btn_addProduct.Text = "ADD";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Barcode:";
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(108, 56);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(591, 20);
            this.tb_barcode.TabIndex = 11;
            this.tb_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_barcode_KeyPress);
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.totalAmount.Location = new System.Drawing.Point(21, 266);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(232, 29);
            this.totalAmount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Amount:";
            // 
            // cb_discount
            // 
            this.cb_discount.AutoSize = true;
            this.cb_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cb_discount.Location = new System.Drawing.Point(16, 118);
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(85, 24);
            this.cb_discount.TabIndex = 8;
            this.cb_discount.Text = "Discount";
            this.cb_discount.UseVisualStyleBackColor = true;
            this.cb_discount.CheckedChanged += new System.EventHandler(this.cb_discount_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(225, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_saveEdit);
            this.panel1.Controls.Add(this.tb_editValue);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_newreceipt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.f2edit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.summaryBox);
            this.panel1.Location = new System.Drawing.Point(891, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 507);
            this.panel1.TabIndex = 10;
            // 
            // btn_saveEdit
            // 
            this.btn_saveEdit.Enabled = false;
            this.btn_saveEdit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_saveEdit.FlatAppearance.BorderSize = 2;
            this.btn_saveEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_saveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveEdit.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEdit.Location = new System.Drawing.Point(193, 100);
            this.btn_saveEdit.Name = "btn_saveEdit";
            this.btn_saveEdit.Size = new System.Drawing.Size(75, 24);
            this.btn_saveEdit.TabIndex = 10;
            this.btn_saveEdit.Text = "Save";
            this.btn_saveEdit.UseVisualStyleBackColor = true;
            this.btn_saveEdit.Click += new System.EventHandler(this.btn_saveEdit_Click);
            // 
            // tb_editValue
            // 
            this.tb_editValue.Enabled = false;
            this.tb_editValue.Location = new System.Drawing.Point(13, 102);
            this.tb_editValue.Name = "tb_editValue";
            this.tb_editValue.Size = new System.Drawing.Size(174, 20);
            this.tb_editValue.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(225, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "New";
            // 
            // btn_newreceipt
            // 
            this.btn_newreceipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_newreceipt.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_newreceipt.FlatAppearance.BorderSize = 3;
            this.btn_newreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newreceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_newreceipt.Location = new System.Drawing.Point(213, 17);
            this.btn_newreceipt.Name = "btn_newreceipt";
            this.btn_newreceipt.Size = new System.Drawing.Size(50, 50);
            this.btn_newreceipt.TabIndex = 7;
            this.btn_newreceipt.Text = "F4";
            this.btn_newreceipt.UseVisualStyleBackColor = false;
            this.btn_newreceipt.Click += new System.EventHandler(this.btn_newreceipt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(128, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Edit";
            // 
            // f2edit
            // 
            this.f2edit.BackColor = System.Drawing.Color.Transparent;
            this.f2edit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.f2edit.FlatAppearance.BorderSize = 3;
            this.f2edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.f2edit.Location = new System.Drawing.Point(116, 17);
            this.f2edit.Name = "f2edit";
            this.f2edit.Size = new System.Drawing.Size(50, 50);
            this.f2edit.TabIndex = 5;
            this.f2edit.Text = "F2";
            this.f2edit.UseVisualStyleBackColor = false;
            this.f2edit.Click += new System.EventHandler(this.editCell_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Print";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_print.FlatAppearance.BorderSize = 3;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_print.Location = new System.Drawing.Point(19, 17);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(50, 50);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "F3";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.txt_discountP);
            this.summaryBox.Controls.Add(this.label14);
            this.summaryBox.Controls.Add(this.txtVat);
            this.summaryBox.Controls.Add(this.label12);
            this.summaryBox.Controls.Add(this.totalAmount);
            this.summaryBox.Controls.Add(this.label6);
            this.summaryBox.Controls.Add(this.cb_discount);
            this.summaryBox.Controls.Add(this.label5);
            this.summaryBox.Controls.Add(this.discountPct);
            this.summaryBox.Controls.Add(this.label4);
            this.summaryBox.Controls.Add(this.lessVAT);
            this.summaryBox.Controls.Add(this.label3);
            this.summaryBox.Controls.Add(this.subTotal);
            this.summaryBox.Controls.Add(this.label2);
            this.summaryBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.summaryBox.Location = new System.Drawing.Point(3, 197);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(271, 307);
            this.summaryBox.TabIndex = 0;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary";
            // 
            // txt_discountP
            // 
            this.txt_discountP.AutoSize = true;
            this.txt_discountP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt_discountP.Location = new System.Drawing.Point(142, 199);
            this.txt_discountP.Name = "txt_discountP";
            this.txt_discountP.Size = new System.Drawing.Size(0, 15);
            this.txt_discountP.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(18, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Discount Price:";
            // 
            // txtVat
            // 
            this.txtVat.AutoSize = true;
            this.txtVat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtVat.Location = new System.Drawing.Point(142, 214);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(0, 15);
            this.txtVat.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(18, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "VAT Price:";
            // 
            // discountPct
            // 
            this.discountPct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.discountPct.Location = new System.Drawing.Point(139, 116);
            this.discountPct.Name = "discountPct";
            this.discountPct.Size = new System.Drawing.Size(81, 29);
            this.discountPct.TabIndex = 6;
            this.discountPct.Text = "0";
            this.discountPct.TextChanged += new System.EventHandler(this.discountPct_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(225, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            // 
            // lessVAT
            // 
            this.lessVAT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lessVAT.Location = new System.Drawing.Point(139, 73);
            this.lessVAT.Name = "lessVAT";
            this.lessVAT.ReadOnly = true;
            this.lessVAT.Size = new System.Drawing.Size(81, 29);
            this.lessVAT.TabIndex = 3;
            this.lessVAT.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Less VAT";
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.subTotal.Location = new System.Drawing.Point(139, 28);
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Size = new System.Drawing.Size(114, 29);
            this.subTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub-Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transaction #:";
            // 
            // transaction_id
            // 
            this.transaction_id.AutoSize = true;
            this.transaction_id.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_id.Location = new System.Drawing.Point(182, 7);
            this.transaction_id.Name = "transaction_id";
            this.transaction_id.Size = new System.Drawing.Size(49, 32);
            this.transaction_id.TabIndex = 8;
            this.transaction_id.Text = "001";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.Red;
            this.statusText.Location = new System.Drawing.Point(337, 79);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 17);
            this.statusText.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 547);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(666, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "Mini Mart POS System by Neil Cedric C. Sapno | Creek Yorem Blanca | Yansey Jones " +
    "Salamputan | Earl Charles Cruz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1182, 572);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.receiptTable);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transaction_id);
            this.Controls.Add(this.statusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS ILS2";
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView receiptTable;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_newreceipt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button f2edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.TextBox discountPct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lessVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transaction_id;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button btn_saveEdit;
        private System.Windows.Forms.TextBox tb_editValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ProdDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pricePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_totalPrice;
        private System.Windows.Forms.Label txtVat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_discountP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

