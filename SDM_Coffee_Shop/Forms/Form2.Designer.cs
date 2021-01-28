
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
            this.imgAbout = new System.Windows.Forms.Button();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblAboutDescription = new System.Windows.Forms.Label();
            this.btnAboutBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgAbout
            // 
            this.imgAbout.BackgroundImage = global::SDM_Coffee_Shop.Properties.Resources.wsour1;
            this.imgAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAbout.Location = new System.Drawing.Point(13, 32);
            this.imgAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(300, 308);
            this.imgAbout.TabIndex = 1;
            this.imgAbout.UseVisualStyleBackColor = true;
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.Location = new System.Drawing.Point(359, 44);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(51, 20);
            this.lblAboutTitle.TabIndex = 3;
            this.lblAboutTitle.Text = "label1";
            // 
            // lblAboutDescription
            // 
            this.lblAboutDescription.AutoSize = true;
            this.lblAboutDescription.Location = new System.Drawing.Point(361, 91);
            this.lblAboutDescription.Name = "lblAboutDescription";
            this.lblAboutDescription.Size = new System.Drawing.Size(51, 20);
            this.lblAboutDescription.TabIndex = 4;
            this.lblAboutDescription.Text = "label2";
            // 
            // btnAboutBack
            // 
            this.btnAboutBack.Location = new System.Drawing.Point(711, 303);
            this.btnAboutBack.Name = "btnAboutBack";
            this.btnAboutBack.Size = new System.Drawing.Size(144, 37);
            this.btnAboutBack.TabIndex = 5;
            this.btnAboutBack.Text = "Back";
            this.btnAboutBack.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 352);
            this.Controls.Add(this.btnAboutBack);
            this.Controls.Add(this.lblAboutDescription);
            this.Controls.Add(this.lblAboutTitle);
            this.Controls.Add(this.imgAbout);
            this.Name = "FormAbout";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imgAbout;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAboutDescription;
        private System.Windows.Forms.Button btnAboutBack;
    }
}