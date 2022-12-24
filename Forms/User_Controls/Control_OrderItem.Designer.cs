namespace CoffeShopManagement.Forms.User_Controls
{
    partial class Control_OrderItem
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.pbxReady = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReady)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(3, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(173, 69);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Espresso";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.BackgroundImage = global::CoffeShopManagement.Properties.Resources.minus;
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(182, 10);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(48, 48);
            this.btnRemoveProduct.TabIndex = 2;
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // pbxReady
            // 
            this.pbxReady.Image = global::CoffeShopManagement.Properties.Resources._checked;
            this.pbxReady.InitialImage = global::CoffeShopManagement.Properties.Resources._checked;
            this.pbxReady.Location = new System.Drawing.Point(182, 10);
            this.pbxReady.Name = "pbxReady";
            this.pbxReady.Size = new System.Drawing.Size(48, 48);
            this.pbxReady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReady.TabIndex = 3;
            this.pbxReady.TabStop = false;
            // 
            // Control_OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pbxReady);
            this.Name = "Control_OrderItem";
            this.Size = new System.Drawing.Size(241, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pbxReady)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.PictureBox pbxReady;
    }
}
