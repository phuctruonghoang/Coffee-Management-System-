namespace QLCOFFEE
{
    partial class frmRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBill = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtEndate = new System.Windows.Forms.DateTimePicker();
            this.btnVeiwBill = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvBill.Location = new System.Drawing.Point(2, 42);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(665, 336);
            this.dtgvBill.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Thời gian bắt đầu:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(126, 8);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtStartDate.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(339, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Thời gian kết thúc:";
            // 
            // dtEndate
            // 
            this.dtEndate.Location = new System.Drawing.Point(453, 9);
            this.dtEndate.Name = "dtEndate";
            this.dtEndate.Size = new System.Drawing.Size(200, 21);
            this.dtEndate.TabIndex = 4;
            // 
            // btnVeiwBill
            // 
            this.btnVeiwBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVeiwBill.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVeiwBill.Location = new System.Drawing.Point(468, 383);
            this.btnVeiwBill.Name = "btnVeiwBill";
            this.btnVeiwBill.Size = new System.Drawing.Size(75, 23);
            this.btnVeiwBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVeiwBill.TabIndex = 5;
            this.btnVeiwBill.Text = "Thống kê";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(582, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 22);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            // 
            // frmRevenue
            // 
            this.AcceptButton = this.btnVeiwBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(669, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVeiwBill);
            this.Controls.Add(this.dtEndate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgvBill);
            this.Name = "frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvBill;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DateTimePicker dtEndate;
        private DevComponents.DotNetBar.ButtonX btnVeiwBill;
        private DevComponents.DotNetBar.ButtonX btnExit;
    }
}