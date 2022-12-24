namespace CoffeShopManagement.Forms.User_Controls
{
    partial class Desk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeskNumber = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblWaiterName = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeskNumber
            // 
            this.lblDeskNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeskNumber.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeskNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeskNumber.Location = new System.Drawing.Point(0, 0);
            this.lblDeskNumber.Name = "lblDeskNumber";
            this.lblDeskNumber.Size = new System.Drawing.Size(290, 47);
            this.lblDeskNumber.TabIndex = 2;
            this.lblDeskNumber.Text = "1";
            this.lblDeskNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.Location = new System.Drawing.Point(15, 15);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(186, 41);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Sipariş Aç";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Visible = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblWaiter
            // 
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWaiter.Location = new System.Drawing.Point(12, 47);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(266, 31);
            this.lblWaiter.TabIndex = 4;
            this.lblWaiter.Text = "Garson";
            this.lblWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaiter.Visible = false;
            // 
            // lblWaiterName
            // 
            this.lblWaiterName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaiterName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWaiterName.Location = new System.Drawing.Point(12, 78);
            this.lblWaiterName.Name = "lblWaiterName";
            this.lblWaiterName.Size = new System.Drawing.Size(266, 25);
            this.lblWaiterName.TabIndex = 5;
            this.lblWaiterName.Text = "isim";
            this.lblWaiterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaiterName.Visible = false;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.Location = new System.Drawing.Point(15, 62);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(186, 41);
            this.btnEditOrder.TabIndex = 6;
            this.btnEditOrder.Text = "Sipariş Düzenle";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Visible = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoSize = true;
            this.pnlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlButtons.Controls.Add(this.btnCreateOrder);
            this.pnlButtons.Controls.Add(this.btnEditOrder);
            this.pnlButtons.Controls.Add(this.btnCloseOrder);
            this.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlButtons.Location = new System.Drawing.Point(37, 106);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(12);
            this.pnlButtons.Size = new System.Drawing.Size(216, 165);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseOrder.Location = new System.Drawing.Point(15, 109);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(186, 41);
            this.btnCloseOrder.TabIndex = 7;
            this.btnCloseOrder.Text = "Sipariş Kapat";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Visible = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblWaiterName);
            this.Controls.Add(this.lblWaiter);
            this.Controls.Add(this.lblDeskNumber);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Desk";
            this.Size = new System.Drawing.Size(290, 290);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeskNumber;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblWaiterName;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnCloseOrder;
    }
}
