namespace Lab2
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
            this.PriceofMeallabel = new System.Windows.Forms.Label();
            this.firstNumTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TIP_15label = new System.Windows.Forms.Label();
            this.TIP_18label = new System.Windows.Forms.Label();
            this.TIP_20label = new System.Windows.Forms.Label();
            this.CalculateTipbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceofMeallabel
            // 
            this.PriceofMeallabel.AutoSize = true;
            this.PriceofMeallabel.Location = new System.Drawing.Point(25, 13);
            this.PriceofMeallabel.Name = "PriceofMeallabel";
            this.PriceofMeallabel.Size = new System.Drawing.Size(98, 13);
            this.PriceofMeallabel.TabIndex = 0;
            this.PriceofMeallabel.Text = "Enter price of meal:";
            this.PriceofMeallabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNumTxt
            // 
            this.firstNumTxt.Location = new System.Drawing.Point(130, 13);
            this.firstNumTxt.Name = "firstNumTxt";
            this.firstNumTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNumTxt.TabIndex = 1;
            this.firstNumTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "15 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "18 %";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "20 %";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TIP_15label
            // 
            this.TIP_15label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIP_15label.Location = new System.Drawing.Point(130, 49);
            this.TIP_15label.Name = "TIP_15label";
            this.TIP_15label.Size = new System.Drawing.Size(100, 23);
            this.TIP_15label.TabIndex = 6;
            this.TIP_15label.Text = "\r\n";
            this.TIP_15label.Click += new System.EventHandler(this.label5_Click);
            // 
            // TIP_18label
            // 
            this.TIP_18label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIP_18label.Location = new System.Drawing.Point(130, 96);
            this.TIP_18label.Name = "TIP_18label";
            this.TIP_18label.Size = new System.Drawing.Size(100, 24);
            this.TIP_18label.TabIndex = 7;
            this.TIP_18label.Click += new System.EventHandler(this.label6_Click);
            // 
            // TIP_20label
            // 
            this.TIP_20label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIP_20label.Location = new System.Drawing.Point(130, 140);
            this.TIP_20label.Name = "TIP_20label";
            this.TIP_20label.Size = new System.Drawing.Size(100, 22);
            this.TIP_20label.TabIndex = 8;
            // 
            // CalculateTipbutton
            // 
            this.CalculateTipbutton.Location = new System.Drawing.Point(90, 193);
            this.CalculateTipbutton.Name = "CalculateTipbutton";
            this.CalculateTipbutton.Size = new System.Drawing.Size(83, 23);
            this.CalculateTipbutton.TabIndex = 9;
            this.CalculateTipbutton.Text = "Calculate Tip";
            this.CalculateTipbutton.UseVisualStyleBackColor = true;
            this.CalculateTipbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 257);
            this.Controls.Add(this.CalculateTipbutton);
            this.Controls.Add(this.TIP_20label);
            this.Controls.Add(this.TIP_18label);
            this.Controls.Add(this.TIP_15label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumTxt);
            this.Controls.Add(this.PriceofMeallabel);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceofMeallabel;
        private System.Windows.Forms.TextBox firstNumTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TIP_15label;
        private System.Windows.Forms.Label TIP_18label;
        private System.Windows.Forms.Label TIP_20label;
        private System.Windows.Forms.Button CalculateTipbutton;
    }
}

