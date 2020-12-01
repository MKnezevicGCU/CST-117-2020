
namespace Exercise_4
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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.secondsInputTextBox = new System.Windows.Forms.TextBox();
            this.minutesAnswerLabel = new System.Windows.Forms.Label();
            this.minutesOutputLabel = new System.Windows.Forms.Label();
            this.hoursQuestionLabel = new System.Windows.Forms.Label();
            this.hoursOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daysOutputLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(118, 27);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(137, 13);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Enter a number of seconds:";
            // 
            // secondsInputTextBox
            // 
            this.secondsInputTextBox.Location = new System.Drawing.Point(261, 20);
            this.secondsInputTextBox.Name = "secondsInputTextBox";
            this.secondsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsInputTextBox.TabIndex = 1;
            // 
            // minutesAnswerLabel
            // 
            this.minutesAnswerLabel.AutoSize = true;
            this.minutesAnswerLabel.Location = new System.Drawing.Point(20, 72);
            this.minutesAnswerLabel.Name = "minutesAnswerLabel";
            this.minutesAnswerLabel.Size = new System.Drawing.Size(235, 13);
            this.minutesAnswerLabel.TabIndex = 2;
            this.minutesAnswerLabel.Text = "How many minutes are in the seconds you input:";
            // 
            // minutesOutputLabel
            // 
            this.minutesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesOutputLabel.Location = new System.Drawing.Point(262, 62);
            this.minutesOutputLabel.Name = "minutesOutputLabel";
            this.minutesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.minutesOutputLabel.TabIndex = 3;
            this.minutesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursQuestionLabel
            // 
            this.hoursQuestionLabel.AutoSize = true;
            this.hoursQuestionLabel.Location = new System.Drawing.Point(30, 114);
            this.hoursQuestionLabel.Name = "hoursQuestionLabel";
            this.hoursQuestionLabel.Size = new System.Drawing.Size(225, 13);
            this.hoursQuestionLabel.TabIndex = 4;
            this.hoursQuestionLabel.Text = "How many hours are in the seconds you input:";
            // 
            // hoursOutputLabel
            // 
            this.hoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOutputLabel.Location = new System.Drawing.Point(262, 104);
            this.hoursOutputLabel.Name = "hoursOutputLabel";
            this.hoursOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.hoursOutputLabel.TabIndex = 5;
            this.hoursOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many days are in the seconds you input:";
            // 
            // daysOutputLabel
            // 
            this.daysOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysOutputLabel.Location = new System.Drawing.Point(262, 147);
            this.daysOutputLabel.Name = "daysOutputLabel";
            this.daysOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.daysOutputLabel.TabIndex = 7;
            this.daysOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(121, 202);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 39);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(246, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.daysOutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursOutputLabel);
            this.Controls.Add(this.hoursQuestionLabel);
            this.Controls.Add(this.minutesOutputLabel);
            this.Controls.Add(this.minutesAnswerLabel);
            this.Controls.Add(this.secondsInputTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Name = "Form1";
            this.Text = "Time calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox secondsInputTextBox;
        private System.Windows.Forms.Label minutesAnswerLabel;
        private System.Windows.Forms.Label minutesOutputLabel;
        private System.Windows.Forms.Label hoursQuestionLabel;
        private System.Windows.Forms.Label hoursOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daysOutputLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button exitButton;
    }
}

