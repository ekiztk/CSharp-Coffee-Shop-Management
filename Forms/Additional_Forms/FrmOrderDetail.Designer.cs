namespace CoffeShopManagement.Forms.Additional_Forms
{
    partial class FrmOrderDetail
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
            this.flpOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnNextCategory = new System.Windows.Forms.Button();
            this.btnPreviousCategory = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpOrderItems
            // 
            this.flpOrderItems.AutoScroll = true;
            this.flpOrderItems.Location = new System.Drawing.Point(610, 51);
            this.flpOrderItems.Name = "flpOrderItems";
            this.flpOrderItems.Padding = new System.Windows.Forms.Padding(8);
            this.flpOrderItems.Size = new System.Drawing.Size(320, 365);
            this.flpOrderItems.TabIndex = 0;
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.tblProducts);
            this.pnlProducts.Controls.Add(this.lblCategoryName);
            this.pnlProducts.Controls.Add(this.btnNextCategory);
            this.pnlProducts.Controls.Add(this.btnPreviousCategory);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(584, 513);
            this.pnlProducts.TabIndex = 1;
            // 
            // tblProducts
            // 
            this.tblProducts.AutoScroll = true;
            this.tblProducts.ColumnCount = 2;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProducts.Location = new System.Drawing.Point(12, 63);
            this.tblProducts.Margin = new System.Windows.Forms.Padding(0);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.Padding = new System.Windows.Forms.Padding(2);
            this.tblProducts.RowCount = 4;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProducts.Size = new System.Drawing.Size(560, 438);
            this.tblProducts.TabIndex = 4;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Location = new System.Drawing.Point(120, 9);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(371, 48);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Kategori";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNextCategory
            // 
            this.btnNextCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCategory.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCategory.Location = new System.Drawing.Point(66, 9);
            this.btnNextCategory.Name = "btnNextCategory";
            this.btnNextCategory.Size = new System.Drawing.Size(48, 48);
            this.btnNextCategory.TabIndex = 1;
            this.btnNextCategory.Text = ">";
            this.btnNextCategory.UseVisualStyleBackColor = true;
            this.btnNextCategory.Click += new System.EventHandler(this.btnNextCategory_Click);
            // 
            // btnPreviousCategory
            // 
            this.btnPreviousCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousCategory.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousCategory.Location = new System.Drawing.Point(12, 9);
            this.btnPreviousCategory.Name = "btnPreviousCategory";
            this.btnPreviousCategory.Size = new System.Drawing.Size(48, 48);
            this.btnPreviousCategory.TabIndex = 0;
            this.btnPreviousCategory.Text = "<";
            this.btnPreviousCategory.UseVisualStyleBackColor = true;
            this.btnPreviousCategory.Click += new System.EventHandler(this.btnPreviousCategory_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.Location = new System.Drawing.Point(610, 458);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(320, 52);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Onayla";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürünler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(610, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adisyon:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalPrice.Location = new System.Drawing.Point(789, 419);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(141, 36);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "100$";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Black;
            this.pnlLine.Location = new System.Drawing.Point(590, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(10, 513);
            this.pnlLine.TabIndex = 7;
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 513);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.flpOrderItems);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrderDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detay";
            this.TopMost = true;
            this.pnlProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOrderItems;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Button btnPreviousCategory;
        private System.Windows.Forms.Button btnNextCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlLine;
    }
}