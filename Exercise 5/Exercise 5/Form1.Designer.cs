
namespace Exercise_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.termsLabel = new System.Windows.Forms.Label();
            this.numberTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.valuePILabel = new System.Windows.Forms.Label();
            this.piLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(79, 60);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(85, 13);
            this.termsLabel.TabIndex = 0;
            this.termsLabel.Text = "Enter # of terms:";
            // 
            // numberTermsTextBox
            // 
            this.numberTermsTextBox.Location = new System.Drawing.Point(171, 52);
            this.numberTermsTextBox.Name = "numberTermsTextBox";
            this.numberTermsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTermsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(82, 112);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(84, 43);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // valuePILabel
            // 
            this.valuePILabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuePILabel.Location = new System.Drawing.Point(82, 196);
            this.valuePILabel.Name = "valuePILabel";
            this.valuePILabel.Size = new System.Drawing.Size(286, 23);
            this.valuePILabel.TabIndex = 3;
            // 
            // piLabel
            // 
            this.piLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piLabel.Location = new System.Drawing.Point(82, 253);
            this.piLabel.Name = "piLabel";
            this.piLabel.Size = new System.Drawing.Size(286, 23);
            this.piLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 334);
            this.Controls.Add(this.piLabel);
            this.Controls.Add(this.valuePILabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberTermsTextBox);
            this.Controls.Add(this.termsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.TextBox numberTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label valuePILabel;
        private System.Windows.Forms.Label piLabel;
    }
}

