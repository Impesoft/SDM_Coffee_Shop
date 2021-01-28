
namespace SDM_Coffee_Shop.UserControls
{
    partial class UserControl1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnInfosmall = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 235);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(21, 264);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "price";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToCart.Location = new System.Drawing.Point(21, 301);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(200, 32);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Order!";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnInfosmall
            // 
            this.btnInfosmall.Location = new System.Drawing.Point(181, 237);
            this.btnInfosmall.Name = "btnInfosmall";
            this.btnInfosmall.Size = new System.Drawing.Size(40, 40);
            this.btnInfosmall.TabIndex = 4;
            this.btnInfosmall.Text = "info";
            this.btnInfosmall.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::SDM_Coffee_Shop.Properties.Resources.wsour1;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Location = new System.Drawing.Point(21, 16);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 200);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInfosmall);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInfo);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(244, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnInfosmall;
    }
}
