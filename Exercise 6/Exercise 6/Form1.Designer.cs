
namespace Exercise_6
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
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.dice1Label = new System.Windows.Forms.Label();
            this.dice2Label = new System.Windows.Forms.Label();
            this.triesStaticLabel = new System.Windows.Forms.Label();
            this.triesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(58, 12);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(75, 36);
            this.rollDiceButton.TabIndex = 0;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // dice1Label
            // 
            this.dice1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1Label.Location = new System.Drawing.Point(153, 12);
            this.dice1Label.Name = "dice1Label";
            this.dice1Label.Size = new System.Drawing.Size(41, 36);
            this.dice1Label.TabIndex = 1;
            this.dice1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice2Label
            // 
            this.dice2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2Label.Location = new System.Drawing.Point(210, 12);
            this.dice2Label.Name = "dice2Label";
            this.dice2Label.Size = new System.Drawing.Size(41, 36);
            this.dice2Label.TabIndex = 2;
            this.dice2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // triesStaticLabel
            // 
            this.triesStaticLabel.AutoSize = true;
            this.triesStaticLabel.Location = new System.Drawing.Point(86, 96);
            this.triesStaticLabel.Name = "triesStaticLabel";
            this.triesStaticLabel.Size = new System.Drawing.Size(104, 13);
            this.triesStaticLabel.TabIndex = 3;
            this.triesStaticLabel.Text = "Took this many tries:";
            // 
            // triesLabel
            // 
            this.triesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triesLabel.Location = new System.Drawing.Point(196, 79);
            this.triesLabel.Name = "triesLabel";
            this.triesLabel.Size = new System.Drawing.Size(32, 30);
            this.triesLabel.TabIndex = 4;
            this.triesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 130);
            this.Controls.Add(this.triesLabel);
            this.Controls.Add(this.triesStaticLabel);
            this.Controls.Add(this.dice2Label);
            this.Controls.Add(this.dice1Label);
            this.Controls.Add(this.rollDiceButton);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Label dice1Label;
        private System.Windows.Forms.Label dice2Label;
        private System.Windows.Forms.Label triesStaticLabel;
        private System.Windows.Forms.Label triesLabel;
    }
}

