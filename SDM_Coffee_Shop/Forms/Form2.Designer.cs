
namespace SDM_Coffee_Shop
{
    partial class FormAbout
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
            this.lblAboutDescription = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboutDescription
            // 
            this.lblAboutDescription.AutoSize = true;
            this.lblAboutDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutDescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAboutDescription.Location = new System.Drawing.Point(16, 370);
            this.lblAboutDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAboutDescription.MaximumSize = new System.Drawing.Size(855, 600);
            this.lblAboutDescription.Name = "lblAboutDescription";
            this.lblAboutDescription.Size = new System.Drawing.Size(90, 36);
            this.lblAboutDescription.TabIndex = 4;
            this.lblAboutDescription.Text = "label2";
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(996, 15);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(253, 72);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "Place your order!";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.btnAboutBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDM_Coffee_Shop.Properties.Resources._1bb99f9b0796e8c95b7fd5d3f9950821;
            this.ClientSize = new System.Drawing.Size(1262, 724);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAboutDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAbout";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAboutDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OrderButton;
    }
}