namespace QLCOFFEE
{
    partial class frmAccountProfile
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txbLogin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbDisplayName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbReEnterPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(125, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tên đăng nhập: ";
            // 
            // txbLogin
            // 
            // 
            // 
            // 
            this.txbLogin.Border.Class = "TextBoxBorder";
            this.txbLogin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbLogin.Location = new System.Drawing.Point(12, 41);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.ReadOnly = true;
            this.txbLogin.Size = new System.Drawing.Size(229, 21);
            this.txbLogin.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            // 
            // 
            // 
            this.txbDisplayName.Border.Class = "TextBoxBorder";
            this.txbDisplayName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbDisplayName.Location = new System.Drawing.Point(12, 97);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(229, 21);
            this.txbDisplayName.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(12, 68);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(125, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên hiển thị: ";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.Border.Class = "TextBoxBorder";
            this.tbPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPassword.Location = new System.Drawing.Point(12, 153);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(229, 21);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(12, 124);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(125, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Mật khẩu:";
            // 
            // tbNewPassword
            // 
            // 
            // 
            // 
            this.tbNewPassword.Border.Class = "TextBoxBorder";
            this.tbNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNewPassword.Location = new System.Drawing.Point(12, 209);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(229, 21);
            this.tbNewPassword.TabIndex = 4;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(12, 180);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(125, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Mật khẩu mới:";
            // 
            // tbReEnterPassword
            // 
            // 
            // 
            // 
            this.tbReEnterPassword.Border.Class = "TextBoxBorder";
            this.tbReEnterPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReEnterPassword.Location = new System.Drawing.Point(12, 265);
            this.tbReEnterPassword.Name = "tbReEnterPassword";
            this.tbReEnterPassword.Size = new System.Drawing.Size(229, 21);
            this.tbReEnterPassword.TabIndex = 5;
            this.tbReEnterPassword.UseSystemPasswordChar = true;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(12, 236);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(206, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Nhập lại mật khẩu mới:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(12, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(166, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            // 
            // frmAccountProfile
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(253, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbReEnterPassword);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.labelX1);
            this.Name = "frmAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin tài khoản";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txbLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txbDisplayName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPassword;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNewPassword;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReEnterPassword;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnExit;
    }
}