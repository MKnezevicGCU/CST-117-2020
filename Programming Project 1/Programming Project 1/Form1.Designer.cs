
namespace Programming_Project_1
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
            this.poundsLabel = new System.Windows.Forms.Label();
            this.kilogramLabel = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.kilogramsOutputLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsLabel.Location = new System.Drawing.Point(16, 57);
            this.poundsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(256, 16);
            this.poundsLabel.TabIndex = 0;
            this.poundsLabel.Text = "How many pounds do you wish to convert:";
            // 
            // kilogramLabel
            // 
            this.kilogramLabel.AutoSize = true;
            this.kilogramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramLabel.Location = new System.Drawing.Point(76, 102);
            this.kilogramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kilogramLabel.Name = "kilogramLabel";
            this.kilogramLabel.Size = new System.Drawing.Size(196, 16);
            this.kilogramLabel.TabIndex = 1;
            this.kilogramLabel.Text = "This is your weight in Kilograms:";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(280, 51);
            this.poundsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(170, 22);
            this.poundsTextBox.TabIndex = 2;
            // 
            // kilogramsOutputLabel
            // 
            this.kilogramsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kilogramsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramsOutputLabel.Location = new System.Drawing.Point(280, 90);
            this.kilogramsOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kilogramsOutputLabel.Name = "kilogramsOutputLabel";
            this.kilogramsOutputLabel.Size = new System.Drawing.Size(170, 28);
            this.kilogramsOutputLabel.TabIndex = 3;
            this.kilogramsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(55, 164);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 28);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(322, 164);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 209);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.kilogramsOutputLabel);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.kilogramLabel);
            this.Controls.Add(this.poundsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Convert Pounds to Kilograms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label kilogramLabel;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.Label kilogramsOutputLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

