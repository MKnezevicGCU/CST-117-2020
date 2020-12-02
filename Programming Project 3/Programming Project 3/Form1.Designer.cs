
namespace Programming_Project_3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.lowercaseButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.longestTxt = new System.Windows.Forms.TextBox();
            this.vowelsTxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(28, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 0;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(360, 13);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(105, 41);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // lowercaseButton
            // 
            this.lowercaseButton.Location = new System.Drawing.Point(360, 155);
            this.lowercaseButton.Name = "lowercaseButton";
            this.lowercaseButton.Size = new System.Drawing.Size(105, 41);
            this.lowercaseButton.TabIndex = 2;
            this.lowercaseButton.Text = "To Lowercase";
            this.lowercaseButton.UseVisualStyleBackColor = true;
            this.lowercaseButton.Click += new System.EventHandler(this.lowercaseButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(360, 82);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(105, 41);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(28, 55);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(312, 20);
            this.firstTxt.TabIndex = 6;
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(28, 93);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(312, 20);
            this.lastTxt.TabIndex = 7;
            // 
            // longestTxt
            // 
            this.longestTxt.Location = new System.Drawing.Point(28, 137);
            this.longestTxt.Name = "longestTxt";
            this.longestTxt.Size = new System.Drawing.Size(312, 20);
            this.longestTxt.TabIndex = 8;
            // 
            // vowelsTxt
            // 
            this.vowelsTxt.Location = new System.Drawing.Point(28, 176);
            this.vowelsTxt.Name = "vowelsTxt";
            this.vowelsTxt.Size = new System.Drawing.Size(312, 20);
            this.vowelsTxt.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 236);
            this.Controls.Add(this.vowelsTxt);
            this.Controls.Add(this.longestTxt);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.lowercaseButton);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Programming Project 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button lowercaseButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.TextBox longestTxt;
        private System.Windows.Forms.TextBox vowelsTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

