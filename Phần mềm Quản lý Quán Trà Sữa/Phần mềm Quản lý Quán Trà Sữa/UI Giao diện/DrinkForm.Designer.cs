namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class DrinkForm
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
            this.pnDisplayListDrink = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.dtgvDrink = new System.Windows.Forms.DataGridView();
            this.dtCategory = new System.Windows.Forms.DataGridView();
            this.pnControlTab = new System.Windows.Forms.Panel();
            this.tabCategory = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTabButton();
            this.tabDrink = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTabButton();
            this.pnBar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnDrink = new System.Windows.Forms.Panel();
            this.btnCancelDrink = new System.Windows.Forms.Button();
            this.btnAcceptDrink = new System.Windows.Forms.Button();
            this.pnImage = new System.Windows.Forms.Panel();
            this.ptImage = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.txtNameDrink = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCategory = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtCategoryName = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDisplayListDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).BeginInit();
            this.pnControlTab.SuspendLayout();
            this.pnBar.SuspendLayout();
            this.pnDrink.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            this.pnCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDisplayListDrink
            // 
            this.pnDisplayListDrink.Controls.Add(this.label1);
            this.pnDisplayListDrink.Controls.Add(this.pnName);
            this.pnDisplayListDrink.Controls.Add(this.dtgvDrink);
            this.pnDisplayListDrink.Controls.Add(this.dtCategory);
            this.pnDisplayListDrink.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplayListDrink.Location = new System.Drawing.Point(419, 0);
            this.pnDisplayListDrink.Name = "pnDisplayListDrink";
            this.pnDisplayListDrink.Size = new System.Drawing.Size(414, 455);
            this.pnDisplayListDrink.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách thức uống";
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.LightGreen;
            this.pnName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(414, 66);
            this.pnName.TabIndex = 4;
            // 
            // dtgvDrink
            // 
            this.dtgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDrink.Location = new System.Drawing.Point(0, 0);
            this.dtgvDrink.Name = "dtgvDrink";
            this.dtgvDrink.Size = new System.Drawing.Size(414, 64);
            this.dtgvDrink.TabIndex = 5;
            // 
            // dtCategory
            // 
            this.dtCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtCategory.Location = new System.Drawing.Point(0, 64);
            this.dtCategory.Name = "dtCategory";
            this.dtCategory.Size = new System.Drawing.Size(414, 391);
            this.dtCategory.TabIndex = 6;
            // 
            // pnControlTab
            // 
            this.pnControlTab.Controls.Add(this.tabCategory);
            this.pnControlTab.Controls.Add(this.tabDrink);
            this.pnControlTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlTab.Location = new System.Drawing.Point(0, 0);
            this.pnControlTab.Name = "pnControlTab";
            this.pnControlTab.Size = new System.Drawing.Size(419, 101);
            this.pnControlTab.TabIndex = 1;
            // 
            // tabCategory
            // 
            this.tabCategory.Clr2 = System.Drawing.Color.Black;
            this.tabCategory.ClrBackground = System.Drawing.Color.White;
            this.tabCategory.ClrClick = System.Drawing.Color.White;
            this.tabCategory.ClrMouseHover = System.Drawing.Color.White;
            this.tabCategory.ClrShow = System.Drawing.Color.LightBlue;
            this.tabCategory.FlatAppearance.BorderSize = 0;
            this.tabCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.tabCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.tabCategory.IsClick = false;
            this.tabCategory.LengthLine = 5;
            this.tabCategory.Location = new System.Drawing.Point(203, 50);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.NText = "Loại thức uống";
            this.tabCategory.NTextX = 11;
            this.tabCategory.NTextY = 10;
            this.tabCategory.Size = new System.Drawing.Size(134, 39);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "nTabButton2";
            this.tabCategory.UseVisualStyleBackColor = true;
            this.tabCategory.Click += new System.EventHandler(this.tabCategory_Click);
            // 
            // tabDrink
            // 
            this.tabDrink.Clr2 = System.Drawing.Color.Black;
            this.tabDrink.ClrBackground = System.Drawing.Color.White;
            this.tabDrink.ClrClick = System.Drawing.Color.White;
            this.tabDrink.ClrMouseHover = System.Drawing.Color.White;
            this.tabDrink.ClrShow = System.Drawing.Color.LightBlue;
            this.tabDrink.FlatAppearance.BorderSize = 0;
            this.tabDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabDrink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDrink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.tabDrink.IsClick = true;
            this.tabDrink.LengthLine = 5;
            this.tabDrink.Location = new System.Drawing.Point(61, 50);
            this.tabDrink.Name = "tabDrink";
            this.tabDrink.NText = "Thức uống";
            this.tabDrink.NTextX = 30;
            this.tabDrink.NTextY = 10;
            this.tabDrink.Size = new System.Drawing.Size(134, 39);
            this.tabDrink.TabIndex = 0;
            this.tabDrink.Text = "nTabButton1";
            this.tabDrink.UseVisualStyleBackColor = true;
            this.tabDrink.Click += new System.EventHandler(this.tabDrink_Click);
            // 
            // pnBar
            // 
            this.pnBar.Controls.Add(this.btnDelete);
            this.pnBar.Controls.Add(this.btnEdit);
            this.pnBar.Controls.Add(this.btnAdd);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 101);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(419, 48);
            this.pnBar.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(261, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(162, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 31);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(60, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnDrink
            // 
            this.pnDrink.Controls.Add(this.btnCancelDrink);
            this.pnDrink.Controls.Add(this.btnAcceptDrink);
            this.pnDrink.Controls.Add(this.pnImage);
            this.pnDrink.Controls.Add(this.txtPrice);
            this.pnDrink.Controls.Add(this.txtNameDrink);
            this.pnDrink.Controls.Add(this.cmbSize);
            this.pnDrink.Controls.Add(this.cmbType);
            this.pnDrink.Controls.Add(this.label5);
            this.pnDrink.Controls.Add(this.label4);
            this.pnDrink.Controls.Add(this.label3);
            this.pnDrink.Controls.Add(this.label2);
            this.pnDrink.Location = new System.Drawing.Point(-1, 155);
            this.pnDrink.Name = "pnDrink";
            this.pnDrink.Size = new System.Drawing.Size(414, 288);
            this.pnDrink.TabIndex = 3;
            // 
            // btnCancelDrink
            // 
            this.btnCancelDrink.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelDrink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelDrink.FlatAppearance.BorderSize = 0;
            this.btnCancelDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDrink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDrink.ForeColor = System.Drawing.Color.White;
            this.btnCancelDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDrink.Location = new System.Drawing.Point(17, 200);
            this.btnCancelDrink.Name = "btnCancelDrink";
            this.btnCancelDrink.Size = new System.Drawing.Size(210, 31);
            this.btnCancelDrink.TabIndex = 31;
            this.btnCancelDrink.Text = "Hủy";
            this.btnCancelDrink.UseVisualStyleBackColor = false;
            this.btnCancelDrink.Click += new System.EventHandler(this.btnCancelDrink_Click);
            // 
            // btnAcceptDrink
            // 
            this.btnAcceptDrink.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAcceptDrink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAcceptDrink.FlatAppearance.BorderSize = 0;
            this.btnAcceptDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptDrink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDrink.ForeColor = System.Drawing.Color.White;
            this.btnAcceptDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptDrink.Location = new System.Drawing.Point(18, 163);
            this.btnAcceptDrink.Name = "btnAcceptDrink";
            this.btnAcceptDrink.Size = new System.Drawing.Size(210, 31);
            this.btnAcceptDrink.TabIndex = 30;
            this.btnAcceptDrink.Text = "Thay đổi";
            this.btnAcceptDrink.UseVisualStyleBackColor = false;
            this.btnAcceptDrink.Click += new System.EventHandler(this.btnAcceptDrink_Click);
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.ptImage);
            this.pnImage.Controls.Add(this.panel4);
            this.pnImage.Controls.Add(this.panel3);
            this.pnImage.Controls.Add(this.panel2);
            this.pnImage.Controls.Add(this.panel1);
            this.pnImage.Location = new System.Drawing.Point(254, 131);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(132, 132);
            this.pnImage.TabIndex = 7;
            // 
            // ptImage
            // 
            this.ptImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptImage.Location = new System.Drawing.Point(2, 2);
            this.ptImage.Name = "ptImage";
            this.ptImage.Size = new System.Drawing.Size(128, 128);
            this.ptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage.TabIndex = 32;
            this.ptImage.TabStop = false;
            this.ptImage.Click += new System.EventHandler(this.ptImage_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(130, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 128);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 128);
            this.panel3.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 2);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 2);
            this.panel1.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.ClrBorder = System.Drawing.Color.SeaGreen;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtPrice.Location = new System.Drawing.Point(18, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(197, 23);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtNameDrink
            // 
            this.txtNameDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.txtNameDrink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameDrink.ClrBorder = System.Drawing.Color.SeaGreen;
            this.txtNameDrink.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameDrink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtNameDrink.Location = new System.Drawing.Point(17, 33);
            this.txtNameDrink.Name = "txtNameDrink";
            this.txtNameDrink.Size = new System.Drawing.Size(197, 23);
            this.txtNameDrink.TabIndex = 25;
            this.txtNameDrink.TextChanged += new System.EventHandler(this.txtNameDrink_TextChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSize.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(231, 91);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(154, 23);
            this.cmbSize.TabIndex = 24;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(231, 33);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(154, 23);
            this.cmbType.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(227, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kích cỡ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(227, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Loại thức uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên thức uống";
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCategory.Controls.Add(this.btnCancel);
            this.pnCategory.Controls.Add(this.btnAccept);
            this.pnCategory.Controls.Add(this.txtCategoryName);
            this.pnCategory.Controls.Add(this.label6);
            this.pnCategory.Location = new System.Drawing.Point(49, 152);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(302, 288);
            this.pnCategory.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(14, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(276, 25);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(15, 108);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(276, 25);
            this.btnAccept.TabIndex = 32;
            this.btnAccept.Text = "Thay đổi";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.ClrBorder = System.Drawing.Color.SeaGreen;
            this.txtCategoryName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.txtCategoryName.Location = new System.Drawing.Point(15, 72);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(276, 23);
            this.txtCategoryName.TabIndex = 27;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(78, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tên loại thức uống";
            // 
            // DrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 455);
            this.Controls.Add(this.pnBar);
            this.Controls.Add(this.pnControlTab);
            this.Controls.Add(this.pnDisplayListDrink);
            this.Controls.Add(this.pnDrink);
            this.Controls.Add(this.pnCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DrinkForm";
            this.Load += new System.EventHandler(this.DrinkForm_Load);
            this.pnDisplayListDrink.ResumeLayout(false);
            this.pnDisplayListDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).EndInit();
            this.pnControlTab.ResumeLayout(false);
            this.pnBar.ResumeLayout(false);
            this.pnDrink.ResumeLayout(false);
            this.pnDrink.PerformLayout();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            this.pnCategory.ResumeLayout(false);
            this.pnCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDisplayListDrink;
        private System.Windows.Forms.DataGridView dtgvDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Panel pnControlTab;
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Panel pnDrink;
        private System.Windows.Forms.Panel pnCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbType;
        private CustomControl.nTextbox txtPrice;
        private CustomControl.nTextbox txtNameDrink;
        private CustomControl.nTextbox txtCategoryName;
        private System.Windows.Forms.Label label6;
        private CustomControl.nTabButton tabCategory;
        private CustomControl.nTabButton tabDrink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtCategory;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox ptImage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelDrink;
        private System.Windows.Forms.Button btnAcceptDrink;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}