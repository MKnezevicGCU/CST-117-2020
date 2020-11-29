
namespace Exercise_3
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
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.kilogramLabel = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.kilogramOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(93, 127);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(53, 52);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(141, 13);
            this.poundsLabel.TabIndex = 2;
            this.poundsLabel.Text = "Enter your weight in pounds:";
            // 
            // kilogramLabel
            // 
            this.kilogramLabel.AutoSize = true;
            this.kilogramLabel.Location = new System.Drawing.Point(38, 87);
            this.kilogramLabel.Name = "kilogramLabel";
            this.kilogramLabel.Size = new System.Drawing.Size(156, 13);
            this.kilogramLabel.TabIndex = 3;
            this.kilogramLabel.Text = "This is your weight in Kilograms:";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(215, 45);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(100, 20);
            this.poundsTextBox.TabIndex = 4;
            // 
            // kilogramOutputLabel
            // 
            this.kilogramOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kilogramOutputLabel.Location = new System.Drawing.Point(215, 87);
            this.kilogramOutputLabel.Name = "kilogramOutputLabel";
            this.kilogramOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.kilogramOutputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 252);
            this.Controls.Add(this.kilogramOutputLabel);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.kilogramLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label kilogramLabel;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.Label kilogramOutputLabel;
    }
}

