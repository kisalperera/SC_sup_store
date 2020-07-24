namespace BillGen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillName = new System.Windows.Forms.TextBox();
            this.txtBillCntNo = new System.Windows.Forms.TextBox();
            this.txtBillAdress = new System.Windows.Forms.TextBox();
            this.txtBillInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtBillDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txBillGrandTotal = new System.Windows.Forms.TextBox();
            this.txtBillOther = new System.Windows.Forms.TextBox();
            this.txtBillSubTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBillProceed = new System.Windows.Forms.Button();
            this.txtBillDiscount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBillAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBillProductCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillPrice = new System.Windows.Forms.TextBox();
            this.txtBillDescription = new System.Windows.Forms.TextBox();
            this.btnBillCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invoice #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // txtBillName
            // 
            this.txtBillName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillName.ForeColor = System.Drawing.Color.White;
            this.txtBillName.Location = new System.Drawing.Point(99, 13);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(317, 17);
            this.txtBillName.TabIndex = 5;
            // 
            // txtBillCntNo
            // 
            this.txtBillCntNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillCntNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillCntNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCntNo.ForeColor = System.Drawing.Color.White;
            this.txtBillCntNo.Location = new System.Drawing.Point(99, 71);
            this.txtBillCntNo.Name = "txtBillCntNo";
            this.txtBillCntNo.Size = new System.Drawing.Size(187, 17);
            this.txtBillCntNo.TabIndex = 6;
            this.txtBillCntNo.TextChanged += new System.EventHandler(this.txtBillCntNo_TextChanged);
            // 
            // txtBillAdress
            // 
            this.txtBillAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillAdress.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAdress.ForeColor = System.Drawing.Color.White;
            this.txtBillAdress.Location = new System.Drawing.Point(99, 41);
            this.txtBillAdress.Name = "txtBillAdress";
            this.txtBillAdress.Size = new System.Drawing.Size(317, 17);
            this.txtBillAdress.TabIndex = 7;
            // 
            // txtBillInvoiceNo
            // 
            this.txtBillInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillInvoiceNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillInvoiceNo.ForeColor = System.Drawing.Color.White;
            this.txtBillInvoiceNo.Location = new System.Drawing.Point(598, 13);
            this.txtBillInvoiceNo.Name = "txtBillInvoiceNo";
            this.txtBillInvoiceNo.Size = new System.Drawing.Size(100, 17);
            this.txtBillInvoiceNo.TabIndex = 8;
            // 
            // txtBillDate
            // 
            this.txtBillDate.CalendarForeColor = System.Drawing.Color.Black;
            this.txtBillDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillDate.CalendarTitleBackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtBillDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.txtBillDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBillDate.Location = new System.Drawing.Point(598, 41);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(100, 24);
            this.txtBillDate.TabIndex = 9;
            // 
            // dataGridBill
            // 
            this.dataGridBill.AllowUserToAddRows = false;
            this.dataGridBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridBill.ColumnHeadersHeight = 30;
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Delete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBill.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridBill.EnableHeadersVisualStyles = false;
            this.dataGridBill.Location = new System.Drawing.Point(31, 193);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.RowHeadersVisible = false;
            this.dataGridBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBill.Size = new System.Drawing.Size(731, 121);
            this.dataGridBill.TabIndex = 10;
            this.dataGridBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridBill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridBill_RowPostPaint);
            // 
            // ItemNo
            // 
            this.ItemNo.HeaderText = "Item#";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Cost";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Remove";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(411, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Discount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(411, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Total";
            // 
            // txBillGrandTotal
            // 
            this.txBillGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txBillGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBillGrandTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBillGrandTotal.ForeColor = System.Drawing.Color.White;
            this.txBillGrandTotal.Location = new System.Drawing.Point(496, 418);
            this.txBillGrandTotal.Name = "txBillGrandTotal";
            this.txBillGrandTotal.ReadOnly = true;
            this.txBillGrandTotal.Size = new System.Drawing.Size(97, 17);
            this.txBillGrandTotal.TabIndex = 28;
            // 
            // txtBillOther
            // 
            this.txtBillOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillOther.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillOther.ForeColor = System.Drawing.Color.White;
            this.txtBillOther.Location = new System.Drawing.Point(496, 356);
            this.txtBillOther.Name = "txtBillOther";
            this.txtBillOther.Size = new System.Drawing.Size(98, 17);
            this.txtBillOther.TabIndex = 27;
            this.txtBillOther.TextChanged += new System.EventHandler(this.txtBillOther_TextChanged);
            // 
            // txtBillSubTotal
            // 
            this.txtBillSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillSubTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillSubTotal.ForeColor = System.Drawing.Color.White;
            this.txtBillSubTotal.Location = new System.Drawing.Point(496, 324);
            this.txtBillSubTotal.Name = "txtBillSubTotal";
            this.txtBillSubTotal.ReadOnly = true;
            this.txtBillSubTotal.Size = new System.Drawing.Size(98, 17);
            this.txtBillSubTotal.TabIndex = 27;
            this.txtBillSubTotal.TextChanged += new System.EventHandler(this.txtBillSubTotal_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(411, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Sub Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(411, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Other";
            // 
            // btnBillProceed
            // 
            this.btnBillProceed.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBillProceed.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBillProceed.FlatAppearance.BorderSize = 0;
            this.btnBillProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBillProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillProceed.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillProceed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBillProceed.Location = new System.Drawing.Point(651, 391);
            this.btnBillProceed.Name = "btnBillProceed";
            this.btnBillProceed.Size = new System.Drawing.Size(106, 47);
            this.btnBillProceed.TabIndex = 22;
            this.btnBillProceed.Text = "Proceed";
            this.btnBillProceed.UseVisualStyleBackColor = false;
            this.btnBillProceed.Click += new System.EventHandler(this.btnBillProceed_Click);
            // 
            // txtBillDiscount
            // 
            this.txtBillDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillDiscount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDiscount.ForeColor = System.Drawing.Color.White;
            this.txtBillDiscount.Location = new System.Drawing.Point(496, 388);
            this.txtBillDiscount.Name = "txtBillDiscount";
            this.txtBillDiscount.Size = new System.Drawing.Size(98, 17);
            this.txtBillDiscount.TabIndex = 27;
            this.txtBillDiscount.TextChanged += new System.EventHandler(this.txtBillDiscount_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.txtBillAdress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBillDate);
            this.panel1.Controls.Add(this.txtBillName);
            this.panel1.Controls.Add(this.txtBillCntNo);
            this.panel1.Controls.Add(this.txtBillInvoiceNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 100);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnBillAdd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBillProductCode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBillPrice);
            this.panel2.Controls.Add(this.txtBillDescription);
            this.panel2.Location = new System.Drawing.Point(31, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 63);
            this.panel2.TabIndex = 31;
            // 
            // btnBillAdd
            // 
            this.btnBillAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBillAdd.FlatAppearance.BorderSize = 0;
            this.btnBillAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAdd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBillAdd.Location = new System.Drawing.Point(635, 12);
            this.btnBillAdd.Name = "btnBillAdd";
            this.btnBillAdd.Size = new System.Drawing.Size(63, 39);
            this.btnBillAdd.TabIndex = 22;
            this.btnBillAdd.Text = "Add";
            this.btnBillAdd.UseVisualStyleBackColor = false;
            this.btnBillAdd.Click += new System.EventHandler(this.btnBillAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Stock ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(496, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Price";
            // 
            // txtBillProductCode
            // 
            this.txtBillProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillProductCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillProductCode.ForeColor = System.Drawing.Color.White;
            this.txtBillProductCode.Location = new System.Drawing.Point(22, 29);
            this.txtBillProductCode.Name = "txtBillProductCode";
            this.txtBillProductCode.Size = new System.Drawing.Size(130, 17);
            this.txtBillProductCode.TabIndex = 20;
            this.txtBillProductCode.TextChanged += new System.EventHandler(this.txtBillTotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(199, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // txtBillPrice
            // 
            this.txtBillPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillPrice.ForeColor = System.Drawing.Color.White;
            this.txtBillPrice.Location = new System.Drawing.Point(499, 29);
            this.txtBillPrice.Name = "txtBillPrice";
            this.txtBillPrice.ReadOnly = true;
            this.txtBillPrice.Size = new System.Drawing.Size(100, 17);
            this.txtBillPrice.TabIndex = 20;
            this.txtBillPrice.TextChanged += new System.EventHandler(this.txtBillTotal_TextChanged);
            // 
            // txtBillDescription
            // 
            this.txtBillDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBillDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDescription.ForeColor = System.Drawing.Color.White;
            this.txtBillDescription.Location = new System.Drawing.Point(202, 29);
            this.txtBillDescription.Name = "txtBillDescription";
            this.txtBillDescription.ReadOnly = true;
            this.txtBillDescription.Size = new System.Drawing.Size(255, 17);
            this.txtBillDescription.TabIndex = 19;
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBillCancel.FlatAppearance.BorderSize = 0;
            this.btnBillCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillCancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBillCancel.Location = new System.Drawing.Point(31, 404);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Size = new System.Drawing.Size(107, 31);
            this.btnBillCancel.TabIndex = 22;
            this.btnBillCancel.Text = "Cancel Invoice";
            this.btnBillCancel.UseVisualStyleBackColor = false;
            this.btnBillCancel.Click += new System.EventHandler(this.btnBillCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.btnBillCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBillProceed);
            this.Controls.Add(this.txBillGrandTotal);
            this.Controls.Add(this.txtBillSubTotal);
            this.Controls.Add(this.txtBillDiscount);
            this.Controls.Add(this.txtBillOther);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridBill);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Billing Module";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillName;
        private System.Windows.Forms.TextBox txtBillCntNo;
        private System.Windows.Forms.TextBox txtBillAdress;
        private System.Windows.Forms.TextBox txtBillInvoiceNo;
        private System.Windows.Forms.DateTimePicker txtBillDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txBillGrandTotal;
        private System.Windows.Forms.TextBox txtBillOther;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBillProceed;
        private System.Windows.Forms.TextBox txtBillDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBillAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillPrice;
        private System.Windows.Forms.TextBox txtBillDescription;
        public System.Windows.Forms.DataGridView dataGridBill;
        public System.Windows.Forms.TextBox txtBillSubTotal;
        public System.Windows.Forms.TextBox txtBillProductCode;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

