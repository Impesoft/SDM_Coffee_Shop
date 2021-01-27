
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userControl17 = new SDM_Coffee_Shop.UserControls.UserControl1();
            this.userControl15 = new SDM_Coffee_Shop.UserControls.UserControl1();
            this.userControl13 = new SDM_Coffee_Shop.UserControls.UserControl1();
            this.userControl11 = new SDM_Coffee_Shop.UserControls.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(39, 37);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(51, 20);
            this.lblCoffee.TabIndex = 0;
            this.lblCoffee.Text = "label1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userControl17);
            this.splitContainer1.Panel1.Controls.Add(this.userControl15);
            this.splitContainer1.Panel1.Controls.Add(this.userControl13);
            this.splitContainer1.Panel1.Controls.Add(this.userControl11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(2090, 1428);
            this.splitContainer1.SplitterDistance = 1537;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // userControl17
            // 
            this.userControl17.Location = new System.Drawing.Point(768, 606);
            this.userControl17.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl17.Name = "userControl17";
            this.userControl17.Size = new System.Drawing.Size(366, 551);
            this.userControl17.TabIndex = 6;
            // 
            // userControl15
            // 
            this.userControl15.Location = new System.Drawing.Point(18, 606);
            this.userControl15.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(366, 551);
            this.userControl15.TabIndex = 4;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(768, 18);
            this.userControl13.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(366, 551);
            this.userControl13.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(18, 18);
            this.userControl11.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(366, 551);
            this.userControl11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nieuwe DriesKnop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2090, 1428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblCoffee);
            this.Name = "Form1";
            this.Text = "SDM Coffee Shop ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UserControls.UserControl1 userControl11;
        private UserControls.UserControl1 userControl17;
        private UserControls.UserControl1 userControl15;
        private UserControls.UserControl1 userControl13;
        private System.Windows.Forms.Button button1;
    }
}

