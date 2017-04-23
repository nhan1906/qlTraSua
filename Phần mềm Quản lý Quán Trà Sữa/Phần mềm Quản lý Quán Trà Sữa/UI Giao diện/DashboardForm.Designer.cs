namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.BC_DoanhSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtQLTraSuaDataSet = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.dtQLTraSuaDataSet();
            this.bCDoanhSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDTableAdapter = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.dtQLTraSuaDataSetTableAdapters.CategoriesDTableAdapter();
            this.bC_DoanhSoTableAdapter = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.dtQLTraSuaDataSetTableAdapters.BC_DoanhSoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pndata = new System.Windows.Forms.Panel();
            this.dtThongke = new System.Windows.Forms.DataGridView();
            this.pnCategories = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcceptDrink = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoriesD = new System.Windows.Forms.ComboBox();
            this.circleDashboard2 = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.CircleDashboard();
            this.circleDashboard1 = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.CircleDashboard();
            ((System.ComponentModel.ISupportInitialize)(this.BC_DoanhSoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQLTraSuaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDoanhSoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongke)).BeginInit();
            this.pnCategories.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BC_DoanhSoBindingSource
            // 
            this.BC_DoanhSoBindingSource.DataMember = "BC_DoanhSo";
            this.BC_DoanhSoBindingSource.DataSource = this.dtQLTraSuaDataSet;
            // 
            // dtQLTraSuaDataSet
            // 
            this.dtQLTraSuaDataSet.DataSetName = "dtQLTraSuaDataSet";
            this.dtQLTraSuaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCDoanhSoBindingSource
            // 
            this.bCDoanhSoBindingSource.DataMember = "BC_DoanhSo";
            this.bCDoanhSoBindingSource.DataSource = this.dtQLTraSuaDataSet;
            // 
            // categoriesDBindingSource
            // 
            this.categoriesDBindingSource.DataMember = "CategoriesD";
            this.categoriesDBindingSource.DataSource = this.dtQLTraSuaDataSet;
            // 
            // categoriesDTableAdapter
            // 
            this.categoriesDTableAdapter.ClearBeforeFill = true;
            // 
            // bC_DoanhSoTableAdapter
            // 
            this.bC_DoanhSoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pndata);
            this.panel1.Controls.Add(this.pnCategories);
            this.panel1.Controls.Add(this.pnTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 455);
            this.panel1.TabIndex = 1;
            // 
            // pndata
            // 
            this.pndata.Controls.Add(this.dtThongke);
            this.pndata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndata.Location = new System.Drawing.Point(0, 89);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(493, 366);
            this.pndata.TabIndex = 7;
            // 
            // dtThongke
            // 
            this.dtThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongke.Location = new System.Drawing.Point(21, 6);
            this.dtThongke.Name = "dtThongke";
            this.dtThongke.Size = new System.Drawing.Size(456, 357);
            this.dtThongke.TabIndex = 0;
            // 
            // pnCategories
            // 
            this.pnCategories.Controls.Add(this.dateTimePicker1);
            this.pnCategories.Controls.Add(this.cmbType);
            this.pnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategories.Location = new System.Drawing.Point(0, 37);
            this.pnCategories.Name = "pnCategories";
            this.pnCategories.Size = new System.Drawing.Size(493, 52);
            this.pnCategories.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Thống kê doanh thu tuần",
            "Thống kê doanh thu tháng",
            "Thông kê thức uống theo tuần",
            "Thống kê thức uống theo tháng"});
            this.cmbType.Location = new System.Drawing.Point(21, 15);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(251, 23);
            this.cmbType.TabIndex = 24;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(493, 37);
            this.pnTop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thống kê ";
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
            this.btnAcceptDrink.Location = new System.Drawing.Point(9, 7);
            this.btnAcceptDrink.Name = "btnAcceptDrink";
            this.btnAcceptDrink.Size = new System.Drawing.Size(322, 31);
            this.btnAcceptDrink.TabIndex = 31;
            this.btnAcceptDrink.Text = "In thống kê doanh thu";
            this.btnAcceptDrink.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAcceptDrink);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(493, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 46);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbCategoriesD);
            this.panel3.Controls.Add(this.circleDashboard2);
            this.panel3.Controls.Add(this.circleDashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(493, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 409);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(141, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Biểu đồ";
            // 
            // cmbCategoriesD
            // 
            this.cmbCategoriesD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbCategoriesD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriesD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbCategoriesD.FormattingEnabled = true;
            this.cmbCategoriesD.Items.AddRange(new object[] {
            "Thống kê doanh thu tuần",
            "Thống kê doanh thu tháng",
            "Thông kê thức uống theo tuần",
            "Thống kê thức uống theo tháng"});
            this.cmbCategoriesD.Location = new System.Drawing.Point(54, 78);
            this.cmbCategoriesD.Name = "cmbCategoriesD";
            this.cmbCategoriesD.Size = new System.Drawing.Size(251, 23);
            this.cmbCategoriesD.TabIndex = 25;
            // 
            // circleDashboard2
            // 
            this.circleDashboard2.ColorBackground = System.Drawing.Color.White;
            this.circleDashboard2.ColorMain = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.circleDashboard2.ColorProcess = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(227)))), ((int)(((byte)(178)))));
            this.circleDashboard2.LengthLine = 2;
            this.circleDashboard2.LineColor = System.Drawing.Color.Black;
            this.circleDashboard2.Location = new System.Drawing.Point(115, 120);
            this.circleDashboard2.Name = "circleDashboard2";
            this.circleDashboard2.PercentItem = 0F;
            this.circleDashboard2.Size = new System.Drawing.Size(120, 120);
            this.circleDashboard2.TabIndex = 1;
            // 
            // circleDashboard1
            // 
            this.circleDashboard1.ColorBackground = System.Drawing.Color.White;
            this.circleDashboard1.ColorMain = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.circleDashboard1.ColorProcess = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(227)))), ((int)(((byte)(178)))));
            this.circleDashboard1.LengthLine = 2;
            this.circleDashboard1.LineColor = System.Drawing.Color.Black;
            this.circleDashboard1.Location = new System.Drawing.Point(115, 262);
            this.circleDashboard1.Name = "circleDashboard1";
            this.circleDashboard1.PercentItem = 0F;
            this.circleDashboard1.Size = new System.Drawing.Size(120, 120);
            this.circleDashboard1.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BC_DoanhSoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQLTraSuaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDoanhSoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pndata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtThongke)).EndInit();
            this.pnCategories.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private dtQLTraSuaDataSet dtQLTraSuaDataSet;
        private System.Windows.Forms.BindingSource categoriesDBindingSource;
        private dtQLTraSuaDataSetTableAdapters.CategoriesDTableAdapter categoriesDTableAdapter;
        private System.Windows.Forms.BindingSource bCDoanhSoBindingSource;
        private dtQLTraSuaDataSetTableAdapters.BC_DoanhSoTableAdapter bC_DoanhSoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource BC_DoanhSoBindingSource;
        private System.Windows.Forms.Panel pnCategories;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pndata;
        private System.Windows.Forms.DataGridView dtThongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAcceptDrink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoriesD;
        private CustomControl.CircleDashboard circleDashboard2;
        private CustomControl.CircleDashboard circleDashboard1;
    }
}