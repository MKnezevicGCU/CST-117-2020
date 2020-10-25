namespace Exercise_1_MK
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
            this.firstButton_Click = new System.Windows.Forms.Button();
            this.secondButton_Click = new System.Windows.Forms.Button();
            this.thirdButton_Click = new System.Windows.Forms.Button();
            this.labelFirstTry = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Label();
            this.starPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstButton_Click
            // 
            this.firstButton_Click.Location = new System.Drawing.Point(29, 37);
            this.firstButton_Click.Name = "firstButton_Click";
            this.firstButton_Click.Size = new System.Drawing.Size(90, 23);
            this.firstButton_Click.TabIndex = 1;
            this.firstButton_Click.Text = "Click button 1";
            this.firstButton_Click.UseVisualStyleBackColor = true;
            this.firstButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondButton_Click
            // 
            this.secondButton_Click.Location = new System.Drawing.Point(138, 37);
            this.secondButton_Click.Name = "secondButton_Click";
            this.secondButton_Click.Size = new System.Drawing.Size(91, 23);
            this.secondButton_Click.TabIndex = 2;
            this.secondButton_Click.Text = "Click button 2";
            this.secondButton_Click.UseVisualStyleBackColor = true;
            this.secondButton_Click.Click += new System.EventHandler(this.secondButton_Click_Click);
            // 
            // thirdButton_Click
            // 
            this.thirdButton_Click.Location = new System.Drawing.Point(250, 37);
            this.thirdButton_Click.Name = "thirdButton_Click";
            this.thirdButton_Click.Size = new System.Drawing.Size(104, 23);
            this.thirdButton_Click.TabIndex = 3;
            this.thirdButton_Click.Text = "Click button 3";
            this.thirdButton_Click.UseVisualStyleBackColor = true;
            this.thirdButton_Click.Click += new System.EventHandler(this.thirdButton_Click_Click);
            // 
            // labelFirstTry
            // 
            this.labelFirstTry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirstTry.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstTry.Location = new System.Drawing.Point(61, 76);
            this.labelFirstTry.Name = "labelFirstTry";
            this.labelFirstTry.Size = new System.Drawing.Size(275, 60);
            this.labelFirstTry.TabIndex = 4;
            this.labelFirstTry.Text = "Programming in visual C# is fun!";
            this.labelFirstTry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFirstTry.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(26, 160);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(345, 42);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "What former U.S. president is known for going on an African safari?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(61, 220);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(275, 37);
            this.answerLabel.TabIndex = 6;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(135, 274);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(110, 23);
            this.showAnswerButton.TabIndex = 7;
            this.showAnswerButton.Text = "Show Answer";
            this.showAnswerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAnswerButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // starPictureBox
            // 
            this.starPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.starPictureBox.Image = global::Exercise_1_MK.Properties.Resources.star;
            this.starPictureBox.Location = new System.Drawing.Point(29, 314);
            this.starPictureBox.Name = "starPictureBox";
            this.starPictureBox.Size = new System.Drawing.Size(118, 77);
            this.starPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox.TabIndex = 8;
            this.starPictureBox.TabStop = false;
            this.starPictureBox.Click += new System.EventHandler(this.starPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 461);
            this.Controls.Add(this.starPictureBox);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.labelFirstTry);
            this.Controls.Add(this.thirdButton_Click);
            this.Controls.Add(this.secondButton_Click);
            this.Controls.Add(this.firstButton_Click);
            this.Name = "Form1";
            this.Text = "My first project Exercise 1 MK";
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button firstButton_Click;
        private System.Windows.Forms.Button secondButton_Click;
        private System.Windows.Forms.Button thirdButton_Click;
        private System.Windows.Forms.Label labelFirstTry;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label showAnswerButton;
        private System.Windows.Forms.PictureBox starPictureBox;
    }
}

