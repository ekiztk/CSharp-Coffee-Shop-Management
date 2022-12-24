namespace CoffeShopManagement.Forms.Home_Forms
{
    partial class FrmReports
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
            this.flpReports = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderItemCount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "RAPORLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpReports
            // 
            this.flpReports.AutoScroll = true;
            this.flpReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpReports.Location = new System.Drawing.Point(0, 78);
            this.flpReports.Name = "flpReports";
            this.flpReports.Padding = new System.Windows.Forms.Padding(4);
            this.flpReports.Size = new System.Drawing.Size(930, 551);
            this.flpReports.TabIndex = 4;
            // 
            // cbxDate
            // 
            this.cbxDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Items.AddRange(new object[] {
            "Today ",
            "Last Week",
            "Last Month"});
            this.cbxDate.Location = new System.Drawing.Point(144, 36);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(130, 36);
            this.cbxDate.TabIndex = 5;
            this.cbxDate.SelectedIndexChanged += new System.EventHandler(this.cbxDate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(319, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toplam Sipariş:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderItemCount
            // 
            this.lblOrderItemCount.Location = new System.Drawing.Point(483, 36);
            this.lblOrderItemCount.Name = "lblOrderItemCount";
            this.lblOrderItemCount.Size = new System.Drawing.Size(130, 36);
            this.lblOrderItemCount.TabIndex = 11;
            this.lblOrderItemCount.Text = "00000";
            this.lblOrderItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(788, 35);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(130, 36);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "000";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(619, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toplam Adisyon:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 629);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOrderItemCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpReports);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpReports;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrderItemCount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label6;
    }
}