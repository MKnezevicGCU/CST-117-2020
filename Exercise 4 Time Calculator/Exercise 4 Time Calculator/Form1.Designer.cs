
namespace Exercise_4_Time_Calculator
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.secondsInputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesOutputLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daysOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(24, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(249, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter the number of seconds you wish you convert:";
            // 
            // secondsInputTextBox
            // 
            this.secondsInputTextBox.Location = new System.Drawing.Point(279, 17);
            this.secondsInputTextBox.Name = "secondsInputTextBox";
            this.secondsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsInputTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(265, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(119, 58);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(154, 13);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "This many minutes has passed:";
            // 
            // minutesOutputLabel
            // 
            this.minutesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesOutputLabel.Location = new System.Drawing.Point(279, 48);
            this.minutesOutputLabel.Name = "minutesOutputLabel";
            this.minutesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.minutesOutputLabel.TabIndex = 5;
            this.minutesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(129, 96);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(144, 13);
            this.hoursLabel.TabIndex = 6;
            this.hoursLabel.Text = "This many hours has passed:";
            // 
            // hoursOutputLabel
            // 
            this.hoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOutputLabel.Location = new System.Drawing.Point(279, 86);
            this.hoursOutputLabel.Name = "hoursOutputLabel";
            this.hoursOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.hoursOutputLabel.TabIndex = 7;
            this.hoursOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "This many days has passed:";
            // 
            // daysOutputLabel
            // 
            this.daysOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysOutputLabel.Location = new System.Drawing.Point(279, 122);
            this.daysOutputLabel.Name = "daysOutputLabel";
            this.daysOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.daysOutputLabel.TabIndex = 9;
            this.daysOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daysOutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursOutputLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.minutesOutputLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondsInputTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox secondsInputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label minutesOutputLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label hoursOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daysOutputLabel;
    }
}

