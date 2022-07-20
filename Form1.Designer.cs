namespace First_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateTaxButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateTaxButton
            // 
            this.calculateTaxButton.Location = new System.Drawing.Point(149, 51);
            this.calculateTaxButton.Name = "calculateTaxButton";
            this.calculateTaxButton.Size = new System.Drawing.Size(240, 99);
            this.calculateTaxButton.TabIndex = 0;
            this.calculateTaxButton.Text = "Click Me!";
            this.calculateTaxButton.UseVisualStyleBackColor = true;
            this.calculateTaxButton.Click += new System.EventHandler(this.calculateTaxButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 115);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calculateTaxButton);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button calculateTaxButton;
        private Button button2;
        private Button button3;
    }
}