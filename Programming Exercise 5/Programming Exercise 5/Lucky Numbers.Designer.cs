
namespace Programming_Exercise_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getLuckyNumbersButton = new System.Windows.Forms.Button();
            this.DayBorn = new System.Windows.Forms.TextBox();
            this.favoriteNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numerical day you were born.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Favorite Number";
            // 
            // getLuckyNumbersButton
            // 
            this.getLuckyNumbersButton.Location = new System.Drawing.Point(85, 128);
            this.getLuckyNumbersButton.Name = "getLuckyNumbersButton";
            this.getLuckyNumbersButton.Size = new System.Drawing.Size(165, 40);
            this.getLuckyNumbersButton.TabIndex = 4;
            this.getLuckyNumbersButton.Text = "Get Your Lucky Number";
            this.getLuckyNumbersButton.UseVisualStyleBackColor = true;
            this.getLuckyNumbersButton.Click += new System.EventHandler(this.getLuckyNumbersButton_Click);
            // 
            // DayBorn
            // 
            this.DayBorn.Location = new System.Drawing.Point(182, 33);
            this.DayBorn.Name = "DayBorn";
            this.DayBorn.Size = new System.Drawing.Size(100, 20);
            this.DayBorn.TabIndex = 5;
            // 
            // favoriteNumber
            // 
            this.favoriteNumber.Location = new System.Drawing.Point(182, 66);
            this.favoriteNumber.Name = "favoriteNumber";
            this.favoriteNumber.Size = new System.Drawing.Size(100, 20);
            this.favoriteNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 209);
            this.Controls.Add(this.favoriteNumber);
            this.Controls.Add(this.DayBorn);
            this.Controls.Add(this.getLuckyNumbersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getLuckyNumbersButton;
        private System.Windows.Forms.TextBox DayBorn;
        private System.Windows.Forms.TextBox favoriteNumber;
    }
}

