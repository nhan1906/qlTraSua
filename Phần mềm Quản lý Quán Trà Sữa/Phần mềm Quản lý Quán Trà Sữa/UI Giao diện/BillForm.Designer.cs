using System;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class BillForm
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
            this.pnDrink = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnm = new System.Windows.Forms.Button();
            this.dtgvDrink = new System.Windows.Forms.DataGridView();
            this.pnCategory = new System.Windows.Forms.Panel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinding = new System.Windows.Forms.TextBox();
            this.pnBillInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lsvBillInfo = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pnControl = new System.Windows.Forms.Panel();
            this.lbTable = new System.Windows.Forms.Label();
            this.pnCashout = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTb = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.nButton();
            this.btnNho = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.nButton();
            this.btnL = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.nButton();
            this.nTextbox1 = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDrink.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrink)).BeginInit();
            this.pnCategory.SuspendLayout();
            this.pnBillInfo.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.pnCashout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDrink
            // 
            this.pnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.pnDrink.Controls.Add(this.btnDown);
            this.pnDrink.Controls.Add(this.btnUp);
            this.pnDrink.Controls.Add(this.label4);
            this.pnDrink.Controls.Add(this.panel1);
            this.pnDrink.Controls.Add(this.txtnm);
            this.pnDrink.Controls.Add(this.dtgvDrink);
            this.pnDrink.Controls.Add(this.pnCategory);
            this.pnDrink.Controls.Add(this.txtBinding);
            this.pnDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDrink.Location = new System.Drawing.Point(0, 0);
            this.pnDrink.Name = "pnDrink";
            this.pnDrink.Size = new System.Drawing.Size(324, 455);
            this.pnDrink.TabIndex = 0;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(152)))));
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDown.Location = new System.Drawing.Point(221, 427);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 19);
            this.btnDown.TabIndex = 39;
            this.btnDown.Text = "-";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(152)))));
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUp.Location = new System.Drawing.Point(221, 406);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 19);
            this.btnUp.TabIndex = 38;
            this.btnUp.Text = "+";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kích cỡ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTb);
            this.panel1.Controls.Add(this.btnNho);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Location = new System.Drawing.Point(13, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 50);
            this.panel1.TabIndex = 36;
            // 
            // txtnm
            // 
            this.txtnm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.txtnm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnm.FlatAppearance.BorderSize = 0;
            this.txtnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtnm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.ForeColor = System.Drawing.Color.White;
            this.txtnm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtnm.Location = new System.Drawing.Point(267, 406);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(45, 40);
            this.txtnm.TabIndex = 35;
            this.txtnm.Text = "1";
            this.txtnm.UseVisualStyleBackColor = false;
            // 
            // dtgvDrink
            // 
            this.dtgvDrink.AllowUserToAddRows = false;
            this.dtgvDrink.AllowUserToDeleteRows = false;
            this.dtgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDrink.Location = new System.Drawing.Point(12, 123);
            this.dtgvDrink.Name = "dtgvDrink";
            this.dtgvDrink.ReadOnly = true;
            this.dtgvDrink.Size = new System.Drawing.Size(295, 266);
            this.dtgvDrink.TabIndex = 1;
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnCategory.Controls.Add(this.cmbCategories);
            this.pnCategory.Controls.Add(this.label2);
            this.pnCategory.Controls.Add(this.nTextbox1);
            this.pnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategory.Location = new System.Drawing.Point(0, 0);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(324, 117);
            this.pnCategory.TabIndex = 0;
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(12, 82);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(295, 23);
            this.cmbCategories.TabIndex = 24;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(67, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách thức uống";
            // 
            // txtBinding
            // 
            this.txtBinding.Location = new System.Drawing.Point(111, 226);
            this.txtBinding.Name = "txtBinding";
            this.txtBinding.Size = new System.Drawing.Size(100, 20);
            this.txtBinding.TabIndex = 35;
            this.txtBinding.TextChanged += new System.EventHandler(this.txtBinding_TextChanged);
            // 
            // pnBillInfo
            // 
            this.pnBillInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnBillInfo.Controls.Add(this.label3);
            this.pnBillInfo.Controls.Add(this.txtTotalPrice);
            this.pnBillInfo.Controls.Add(this.lsvBillInfo);
            this.pnBillInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnBillInfo.Location = new System.Drawing.Point(498, 0);
            this.pnBillInfo.Name = "pnBillInfo";
            this.pnBillInfo.Size = new System.Drawing.Size(335, 455);
            this.pnBillInfo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(83, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách thức uống";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(13, 421);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(310, 20);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.nameDrink,
            this.number,
            this.price});
            this.lsvBillInfo.Location = new System.Drawing.Point(13, 82);
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.Size = new System.Drawing.Size(310, 319);
            this.lsvBillInfo.TabIndex = 0;
            this.lsvBillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 34;
            // 
            // nameDrink
            // 
            this.nameDrink.Text = "Tên Thức uống";
            this.nameDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameDrink.Width = 130;
            // 
            // number
            // 
            this.number.Text = "SL";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.Width = 37;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 104;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnControl.Controls.Add(this.lbTable);
            this.pnControl.Controls.Add(this.pnCashout);
            this.pnControl.Controls.Add(this.btnRemove);
            this.pnControl.Controls.Add(this.btnAdd);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(324, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(174, 455);
            this.pnControl.TabIndex = 2;
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTable.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.lbTable.Location = new System.Drawing.Point(51, 30);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(58, 22);
            this.lbTable.TabIndex = 34;
            this.lbTable.Text = "Bàn 1";
            // 
            // pnCashout
            // 
            this.pnCashout.Controls.Add(this.label6);
            this.pnCashout.Controls.Add(this.button5);
            this.pnCashout.Controls.Add(this.label1);
            this.pnCashout.Controls.Add(this.txtCashout);
            this.pnCashout.Controls.Add(this.label5);
            this.pnCashout.Controls.Add(this.txtDiscount);
            this.pnCashout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCashout.Location = new System.Drawing.Point(0, 306);
            this.pnCashout.Name = "pnCashout";
            this.pnCashout.Size = new System.Drawing.Size(174, 149);
            this.pnCashout.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(8, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 31);
            this.button5.TabIndex = 32;
            this.button5.Text = "Thanh toán";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tổng tiền";
            // 
            // txtCashout
            // 
            this.txtCashout.Location = new System.Drawing.Point(8, 75);
            this.txtCashout.Name = "txtCashout";
            this.txtCashout.ReadOnly = true;
            this.txtCashout.Size = new System.Drawing.Size(162, 20);
            this.txtCashout.TabIndex = 22;
            this.txtCashout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giảm giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(6, 26);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(162, 20);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.Text = "10";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.Click += new System.EventHandler(this.txtDiscount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(6, 215);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 31);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove <<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(6, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 31);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTb
            // 
            this.btnTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnTb.ClrBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnTb.ClrClick = System.Drawing.Color.Khaki;
            this.btnTb.ClrMouseHover = System.Drawing.Color.Khaki;
            this.btnTb.ClrShow = System.Drawing.Color.Khaki;
            this.btnTb.FlatAppearance.BorderSize = 0;
            this.btnTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTb.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.btnTb.ForeColor = System.Drawing.Color.White;
            this.btnTb.IsClick = false;
            this.btnTb.Location = new System.Drawing.Point(112, 14);
            this.btnTb.Name = "btnTb";
            this.btnTb.NImage = null;
            this.btnTb.NImageX = 0;
            this.btnTb.NImageY = 0;
            this.btnTb.NText = "TB";
            this.btnTb.NTextX = 8;
            this.btnTb.NTextY = 5;
            this.btnTb.Size = new System.Drawing.Size(40, 28);
            this.btnTb.TabIndex = 37;
            this.btnTb.Text = "nLogin";
            this.btnTb.UseVisualStyleBackColor = false;
            this.btnTb.Click += new System.EventHandler(this.btnTb_Click);
            // 
            // btnNho
            // 
            this.btnNho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnNho.ClrBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnNho.ClrClick = System.Drawing.Color.Khaki;
            this.btnNho.ClrMouseHover = System.Drawing.Color.Khaki;
            this.btnNho.ClrShow = System.Drawing.Color.Khaki;
            this.btnNho.FlatAppearance.BorderSize = 0;
            this.btnNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNho.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.btnNho.ForeColor = System.Drawing.Color.White;
            this.btnNho.IsClick = false;
            this.btnNho.Location = new System.Drawing.Point(66, 14);
            this.btnNho.Name = "btnNho";
            this.btnNho.NImage = null;
            this.btnNho.NImageX = 0;
            this.btnNho.NImageY = 0;
            this.btnNho.NText = "Nhỏ";
            this.btnNho.NTextX = 8;
            this.btnNho.NTextY = 5;
            this.btnNho.Size = new System.Drawing.Size(40, 28);
            this.btnNho.TabIndex = 36;
            this.btnNho.Text = "nLogin";
            this.btnNho.UseVisualStyleBackColor = false;
            this.btnNho.Click += new System.EventHandler(this.btnNho_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnL.ClrBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.btnL.ClrClick = System.Drawing.Color.Khaki;
            this.btnL.ClrMouseHover = System.Drawing.Color.Khaki;
            this.btnL.ClrShow = System.Drawing.Color.Khaki;
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.IsClick = false;
            this.btnL.Location = new System.Drawing.Point(20, 14);
            this.btnL.Name = "btnL";
            this.btnL.NImage = null;
            this.btnL.NImageX = 0;
            this.btnL.NImageY = 0;
            this.btnL.NText = "Lớn";
            this.btnL.NTextX = 8;
            this.btnL.NTextY = 5;
            this.btnL.Size = new System.Drawing.Size(40, 28);
            this.btnL.TabIndex = 35;
            this.btnL.Text = "nLogin";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // nTextbox1
            // 
            this.nTextbox1.ClrBorder = System.Drawing.Color.SeaGreen;
            this.nTextbox1.Location = new System.Drawing.Point(12, 56);
            this.nTextbox1.Name = "nTextbox1";
            this.nTextbox1.Size = new System.Drawing.Size(295, 20);
            this.nTextbox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "%";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 455);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnBillInfo);
            this.Controls.Add(this.pnDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.pnDrink.ResumeLayout(false);
            this.pnDrink.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrink)).EndInit();
            this.pnCategory.ResumeLayout(false);
            this.pnCategory.PerformLayout();
            this.pnBillInfo.ResumeLayout(false);
            this.pnBillInfo.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnCashout.ResumeLayout(false);
            this.pnCashout.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnDrink;
        private System.Windows.Forms.DataGridView dtgvDrink;
        private System.Windows.Forms.Panel pnCategory;
        private CustomControl.nTextbox nTextbox1;
        private System.Windows.Forms.Panel pnBillInfo;
        private System.Windows.Forms.ListView lsvBillInfo;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button txtnm;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnCashout;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader nameDrink;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.TextBox txtBinding;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private nButton btnTb;
        private nButton btnNho;
        private nButton btnL;
        private System.Windows.Forms.Label label6;
    }
}