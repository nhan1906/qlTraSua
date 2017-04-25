namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class PrintHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtQLTraSuaDataSet = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.dtQLTraSuaDataSet();
            this.hDHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hD_HoaDonTableAdapter = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.dtQLTraSuaDataSetTableAdapters.HD_HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtQLTraSuaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hDHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI Giao diện.CustomControl.rpHoadon.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Nhan\\Desktop\\Github\\qlTS\\qlTraSua\\Phần mềm Quản lý Quán Trà Sữa\\Phần mềm" +
    " Quản lý Quán Trà Sữa\\UI Giao diện\\CustomControl\\rpHoadon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(464, 320);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtQLTraSuaDataSet
            // 
            this.dtQLTraSuaDataSet.DataSetName = "dtQLTraSuaDataSet";
            this.dtQLTraSuaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDHoaDonBindingSource
            // 
            this.hDHoaDonBindingSource.DataMember = "HD_HoaDon";
            this.hDHoaDonBindingSource.DataSource = this.dtQLTraSuaDataSet;
            // 
            // hD_HoaDonTableAdapter
            // 
            this.hD_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // PrintHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 320);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintHoaDon";
            this.ShowIcon = false;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.PrintHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtQLTraSuaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dtQLTraSuaDataSet dtQLTraSuaDataSet;
        private System.Windows.Forms.BindingSource hDHoaDonBindingSource;
        private dtQLTraSuaDataSetTableAdapters.HD_HoaDonTableAdapter hD_HoaDonTableAdapter;
    }
}