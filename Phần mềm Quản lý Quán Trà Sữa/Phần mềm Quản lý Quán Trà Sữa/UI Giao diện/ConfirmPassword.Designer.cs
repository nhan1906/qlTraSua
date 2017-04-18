namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    partial class ConfirmPassword
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
            this.txtPassword = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl.nTextbox();
            this.btnConfirm = new Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.nButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.ClrBorder = System.Drawing.Color.SeaGreen;
            this.txtPassword.Location = new System.Drawing.Point(61, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 28);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
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
            this.btnConfirm.Location = new System.Drawing.Point(61, 89);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NImage = null;
            this.btnConfirm.NImageX = 0;
            this.btnConfirm.NImageY = 0;
            this.btnConfirm.NText = "Xác nhận mật khẩu";
            this.btnConfirm.NTextX = 65;
            this.btnConfirm.NTextY = 12;
            this.btnConfirm.Size = new System.Drawing.Size(232, 40);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "nButton1";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu cấp 2";
            // 
            // ConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(358, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmPassword";
            this.Text = "ConfirmPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.nTextbox txtPassword;
        private nButton btnConfirm;
        private System.Windows.Forms.Label label1;
    }
}