
namespace SDM_Coffee_Shop.UserControls
{
    partial class CartControl
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
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142857F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.Color.White;
            this.lblNameProduct.Location = new System.Drawing.Point(29, 13);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(83, 13);
            this.lblNameProduct.TabIndex = 0;
            this.lblNameProduct.Text = "ProductName";
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142857F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProduct.ForeColor = System.Drawing.Color.White;
            this.lblPriceProduct.Location = new System.Drawing.Point(121, 12);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(14, 13);
            this.lblPriceProduct.TabIndex = 1;
            this.lblPriceProduct.Text = "€";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(185, 10);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(31, 23);
            this.btnRemoveFromCart.TabIndex = 2;
            this.btnRemoveFromCart.Text = "X";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblid.Location = new System.Drawing.Point(7, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(17, 13);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "id";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDetails.Location = new System.Drawing.Point(29, 37);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(37, 13);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "details";
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDM_Coffee_Shop.Properties.Resources.pnggg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblPriceProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Margin = new System.Windows.Forms.Padding(100, 13, 3, 3);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(230, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPriceProduct;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblDetails;
    }
}
