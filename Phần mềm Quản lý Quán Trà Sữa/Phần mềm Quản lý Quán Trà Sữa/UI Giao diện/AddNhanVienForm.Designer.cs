namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class AddNhanVienForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.nButton();
            this.txttenNhanVien = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm Nhân Viên";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(201)))));
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(63, 104);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(232, 23);
            this.cmbType.TabIndex = 23;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ClrBackground = System.Drawing.Color.SeaGreen;
            this.btnConfirm.ClrClick = System.Drawing.Color.Black;
            this.btnConfirm.ClrMouseHover = System.Drawing.Color.Black;
            this.btnConfirm.ClrShow = System.Drawing.Color.Blue;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IsClick = false;
            this.btnConfirm.Location = new System.Drawing.Point(63, 147);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NImage = null;
            this.btnConfirm.NImageX = 0;
            this.btnConfirm.NImageY = 0;
            this.btnConfirm.NText = "Xác nhận ";
            this.btnConfirm.NTextX = 92;
            this.btnConfirm.NTextY = 12;
            this.btnConfirm.Size = new System.Drawing.Size(232, 40);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "nButton1";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txttenNhanVien
            // 
            this.txttenNhanVien.ClrBorder = System.Drawing.Color.SeaGreen;
            this.txttenNhanVien.Location = new System.Drawing.Point(63, 59);
            this.txttenNhanVien.Name = "txttenNhanVien";
            this.txttenNhanVien.Size = new System.Drawing.Size(232, 28);
            this.txttenNhanVien.TabIndex = 4;
            // 
            // AddNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(358, 212);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txttenNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNhanVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNhanVienForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private nButton btnConfirm;
        private CustomControl.nTextbox txttenNhanVien;
        private System.Windows.Forms.ComboBox cmbType;
    }
}