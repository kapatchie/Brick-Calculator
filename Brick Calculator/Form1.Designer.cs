namespace Brick_Calculator
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
            this.MaxiChkBox = new System.Windows.Forms.CheckBox();
            this.chkHallowBrick = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.LenghtTxtBox = new System.Windows.Forms.TextBox();
            this.WidthTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.radMaxi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHallow = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaxiChkBox
            // 
            this.MaxiChkBox.Location = new System.Drawing.Point(0, 0);
            this.MaxiChkBox.Name = "MaxiChkBox";
            this.MaxiChkBox.Size = new System.Drawing.Size(104, 24);
            this.MaxiChkBox.TabIndex = 0;
            // 
            // chkHallowBrick
            // 
            this.chkHallowBrick.Location = new System.Drawing.Point(0, 0);
            this.chkHallowBrick.Name = "chkHallowBrick";
            this.chkHallowBrick.Size = new System.Drawing.Size(104, 24);
            this.chkHallowBrick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Witdh";
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Location = new System.Drawing.Point(57, 94);
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTxtBox.TabIndex = 7;
            this.HeightTxtBox.Text = "2.7";
            this.HeightTxtBox.TextChanged += new System.EventHandler(this.HeightTxtBox_TextChanged);
            // 
            // LenghtTxtBox
            // 
            this.LenghtTxtBox.Location = new System.Drawing.Point(57, 120);
            this.LenghtTxtBox.Name = "LenghtTxtBox";
            this.LenghtTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LenghtTxtBox.TabIndex = 8;
            this.LenghtTxtBox.TextChanged += new System.EventHandler(this.LenghtTxtBox_TextChanged);
            // 
            // WidthTxtBox
            // 
            this.WidthTxtBox.Location = new System.Drawing.Point(57, 150);
            this.WidthTxtBox.Name = "WidthTxtBox";
            this.WidthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTxtBox.TabIndex = 9;
            this.WidthTxtBox.TextChanged += new System.EventHandler(this.WidthTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(62, 187);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 11;
            // 
            // radMaxi
            // 
            this.radMaxi.AutoSize = true;
            this.radMaxi.Checked = true;
            this.radMaxi.Location = new System.Drawing.Point(6, 19);
            this.radMaxi.Name = "radMaxi";
            this.radMaxi.Size = new System.Drawing.Size(79, 17);
            this.radMaxi.TabIndex = 13;
            this.radMaxi.TabStop = true;
            this.radMaxi.Text = "Maxi Bricks";
            this.radMaxi.UseVisualStyleBackColor = true;
            this.radMaxi.CheckedChanged += new System.EventHandler(this.radMaxi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHallow);
            this.groupBox1.Controls.Add(this.radMaxi);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Brick";
            // 
            // radHallow
            // 
            this.radHallow.AutoSize = true;
            this.radHallow.Location = new System.Drawing.Point(6, 43);
            this.radHallow.Name = "radHallow";
            this.radHallow.Size = new System.Drawing.Size(89, 17);
            this.radHallow.TabIndex = 14;
            this.radHallow.TabStop = true;
            this.radHallow.Text = "Hallow Bricks";
            this.radHallow.UseVisualStyleBackColor = true;
            this.radHallow.CheckedChanged += new System.EventHandler(this.radHallow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 222);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WidthTxtBox);
            this.Controls.Add(this.LenghtTxtBox);
            this.Controls.Add(this.HeightTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Brick Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MaxiChkBox;
        private System.Windows.Forms.CheckBox chkHallowBrick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.TextBox LenghtTxtBox;
        private System.Windows.Forms.TextBox WidthTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton radMaxi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHallow;
    }
}

