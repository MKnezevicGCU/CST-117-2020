
namespace Programming_Project_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.fillModeGroupBox = new System.Windows.Forms.GroupBox();
            this.outlineRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.shapePictureBox = new System.Windows.Forms.PictureBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.nameOutputLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fillModeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Shape:";
            // 
            // shapeListBox
            // 
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.shapeListBox.Location = new System.Drawing.Point(70, 38);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(120, 69);
            this.shapeListBox.TabIndex = 1;
            // 
            // fillModeGroupBox
            // 
            this.fillModeGroupBox.Controls.Add(this.outlineRadioButton);
            this.fillModeGroupBox.Controls.Add(this.fillRadioButton);
            this.fillModeGroupBox.Location = new System.Drawing.Point(70, 128);
            this.fillModeGroupBox.Name = "fillModeGroupBox";
            this.fillModeGroupBox.Size = new System.Drawing.Size(200, 89);
            this.fillModeGroupBox.TabIndex = 2;
            this.fillModeGroupBox.TabStop = false;
            this.fillModeGroupBox.Text = "Select fill mode:";
            // 
            // outlineRadioButton
            // 
            this.outlineRadioButton.AutoSize = true;
            this.outlineRadioButton.Location = new System.Drawing.Point(28, 54);
            this.outlineRadioButton.Name = "outlineRadioButton";
            this.outlineRadioButton.Size = new System.Drawing.Size(58, 17);
            this.outlineRadioButton.TabIndex = 1;
            this.outlineRadioButton.Text = "Outline";
            this.outlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Checked = true;
            this.fillRadioButton.Location = new System.Drawing.Point(28, 31);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(37, 17);
            this.fillRadioButton.TabIndex = 0;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            this.fillRadioButton.CheckedChanged += new System.EventHandler(this.fillRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCheckBox);
            this.groupBox1.Controls.Add(this.nameCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(70, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(28, 44);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 1;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(28, 20);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.nameCheckBox_CheckedChanged);
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("shapePictureBox.Image")));
            this.shapePictureBox.InitialImage = null;
            this.shapePictureBox.Location = new System.Drawing.Point(335, 38);
            this.shapePictureBox.Name = "shapePictureBox";
            this.shapePictureBox.Size = new System.Drawing.Size(189, 147);
            this.shapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shapePictureBox.TabIndex = 4;
            this.shapePictureBox.TabStop = false;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(377, 194);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.dateOutputLabel.TabIndex = 5;
            // 
            // nameOutputLabel
            // 
            this.nameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutputLabel.Location = new System.Drawing.Point(377, 227);
            this.nameOutputLabel.Name = "nameOutputLabel";
            this.nameOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.nameOutputLabel.TabIndex = 6;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(335, 275);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 43);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(437, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 43);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 347);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.nameOutputLabel);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.shapePictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillModeGroupBox);
            this.Controls.Add(this.shapeListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shape Maker";
            this.fillModeGroupBox.ResumeLayout(false);
            this.fillModeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.GroupBox fillModeGroupBox;
        private System.Windows.Forms.RadioButton outlineRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.PictureBox shapePictureBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Label nameOutputLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
    }
}

