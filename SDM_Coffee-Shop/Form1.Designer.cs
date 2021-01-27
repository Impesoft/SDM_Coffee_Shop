
namespace SDM_Coffee_Shop
{
    partial class Form1
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
            this.lblCoffee = new System.Windows.Forms.Label();
            this.LblTea = new System.Windows.Forms.Label();
            this.LblSmoothie = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(35, 29);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(49, 17);
            this.lblCoffee.TabIndex = 0;
            this.lblCoffee.Text = "Coffee";
            // 
            // LblTea
            // 
            this.LblTea.AutoSize = true;
            this.LblTea.Location = new System.Drawing.Point(169, 29);
            this.LblTea.Name = "LblTea";
            this.LblTea.Size = new System.Drawing.Size(33, 17);
            this.LblTea.TabIndex = 1;
            this.LblTea.Text = "Tea";
            // 
            // LblSmoothie
            // 
            this.LblSmoothie.AutoSize = true;
            this.LblSmoothie.Location = new System.Drawing.Point(302, 28);
            this.LblSmoothie.Name = "LblSmoothie";
            this.LblSmoothie.Size = new System.Drawing.Size(74, 17);
            this.LblSmoothie.TabIndex = 2;
            this.LblSmoothie.Text = "Smoothies";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CBNespresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LblSmoothie);
            this.Controls.Add(this.LblTea);
            this.Controls.Add(this.lblCoffee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CBNespresso";
            this.Text = "SDM Coffee Shop ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label LblTea;
        private System.Windows.Forms.Label LblSmoothie;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

