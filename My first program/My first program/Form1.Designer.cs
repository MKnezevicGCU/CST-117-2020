﻿namespace My_first_program
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
            this.messageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(141, 55);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(106, 35);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 169);
            this.Controls.Add(this.messageButton);
            this.Name = "Form1";
            this.Text = "My first program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
    }
}

