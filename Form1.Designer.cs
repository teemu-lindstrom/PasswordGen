
namespace PasswordGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.label_Length = new System.Windows.Forms.Label();
            this.checkbox_Uppercase = new System.Windows.Forms.CheckBox();
            this.checkbox_Lowercase = new System.Windows.Forms.CheckBox();
            this.checkbox_SpecialChar = new System.Windows.Forms.CheckBox();
            this.checkbox_Numbers = new System.Windows.Forms.CheckBox();
            this.txt_UppercaseMin = new System.Windows.Forms.TextBox();
            this.txt_SpecialCharMin = new System.Windows.Forms.TextBox();
            this.txt_LowercaseMin = new System.Windows.Forms.TextBox();
            this.txt_NumbersMin = new System.Windows.Forms.TextBox();
            this.label_UppercaseMin = new System.Windows.Forms.Label();
            this.label_LowercaseMin = new System.Windows.Forms.Label();
            this.label_SpecialCharMin = new System.Windows.Forms.Label();
            this.label_NumbersMin = new System.Windows.Forms.Label();
            this.label_NumbersMax = new System.Windows.Forms.Label();
            this.label_SpecialCharMax = new System.Windows.Forms.Label();
            this.label_LowercaseMax = new System.Windows.Forms.Label();
            this.label_UppercaseMax = new System.Windows.Forms.Label();
            this.txt_NumbersMax = new System.Windows.Forms.TextBox();
            this.txt_LowercaseMax = new System.Windows.Forms.TextBox();
            this.txt_SpecialCharMax = new System.Windows.Forms.TextBox();
            this.txt_UppercaseMax = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Length
            // 
            this.txt_Length.Location = new System.Drawing.Point(59, 12);
            this.txt_Length.MaxLength = 2;
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(44, 23);
            this.txt_Length.TabIndex = 0;
            this.txt_Length.Text = "8";
            this.txt_Length.TextChanged += new System.EventHandler(this.txt_Length_TextChanged);
            // 
            // label_Length
            // 
            this.label_Length.AutoSize = true;
            this.label_Length.Location = new System.Drawing.Point(9, 15);
            this.label_Length.Name = "label_Length";
            this.label_Length.Size = new System.Drawing.Size(44, 15);
            this.label_Length.TabIndex = 1;
            this.label_Length.Text = "Length";
            // 
            // checkbox_Uppercase
            // 
            this.checkbox_Uppercase.AutoSize = true;
            this.checkbox_Uppercase.Checked = true;
            this.checkbox_Uppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_Uppercase.Location = new System.Drawing.Point(9, 51);
            this.checkbox_Uppercase.Name = "checkbox_Uppercase";
            this.checkbox_Uppercase.Size = new System.Drawing.Size(81, 19);
            this.checkbox_Uppercase.TabIndex = 2;
            this.checkbox_Uppercase.Text = "Uppercase";
            this.checkbox_Uppercase.UseVisualStyleBackColor = true;
            this.checkbox_Uppercase.CheckedChanged += new System.EventHandler(this.checkbox_Uppercase_CheckedChanged);
            // 
            // checkbox_Lowercase
            // 
            this.checkbox_Lowercase.AutoSize = true;
            this.checkbox_Lowercase.Checked = true;
            this.checkbox_Lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_Lowercase.Location = new System.Drawing.Point(9, 76);
            this.checkbox_Lowercase.Name = "checkbox_Lowercase";
            this.checkbox_Lowercase.Size = new System.Drawing.Size(81, 19);
            this.checkbox_Lowercase.TabIndex = 3;
            this.checkbox_Lowercase.Text = "Lowercase";
            this.checkbox_Lowercase.UseVisualStyleBackColor = true;
            this.checkbox_Lowercase.CheckedChanged += new System.EventHandler(this.checkbox_Lowercase_CheckedChanged);
            // 
            // checkbox_SpecialChar
            // 
            this.checkbox_SpecialChar.AutoSize = true;
            this.checkbox_SpecialChar.Location = new System.Drawing.Point(9, 126);
            this.checkbox_SpecialChar.Name = "checkbox_SpecialChar";
            this.checkbox_SpecialChar.Size = new System.Drawing.Size(120, 19);
            this.checkbox_SpecialChar.TabIndex = 4;
            this.checkbox_SpecialChar.Text = "Special characters";
            this.checkbox_SpecialChar.UseVisualStyleBackColor = true;
            this.checkbox_SpecialChar.CheckedChanged += new System.EventHandler(this.checkbox_SpecialChar_CheckedChanged);
            // 
            // checkbox_Numbers
            // 
            this.checkbox_Numbers.AutoSize = true;
            this.checkbox_Numbers.Checked = true;
            this.checkbox_Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_Numbers.Location = new System.Drawing.Point(9, 101);
            this.checkbox_Numbers.Name = "checkbox_Numbers";
            this.checkbox_Numbers.Size = new System.Drawing.Size(75, 19);
            this.checkbox_Numbers.TabIndex = 5;
            this.checkbox_Numbers.Text = "Numbers";
            this.checkbox_Numbers.UseVisualStyleBackColor = true;
            this.checkbox_Numbers.CheckedChanged += new System.EventHandler(this.checkbox_Numbers_CheckedChanged);
            // 
            // txt_UppercaseMin
            // 
            this.txt_UppercaseMin.Location = new System.Drawing.Point(169, 49);
            this.txt_UppercaseMin.Name = "txt_UppercaseMin";
            this.txt_UppercaseMin.Size = new System.Drawing.Size(46, 23);
            this.txt_UppercaseMin.TabIndex = 6;
            this.txt_UppercaseMin.Text = "0";
            this.txt_UppercaseMin.TextChanged += new System.EventHandler(this.txt_UppercaseMin_TextChanged);
            // 
            // txt_SpecialCharMin
            // 
            this.txt_SpecialCharMin.Enabled = false;
            this.txt_SpecialCharMin.Location = new System.Drawing.Point(169, 124);
            this.txt_SpecialCharMin.Name = "txt_SpecialCharMin";
            this.txt_SpecialCharMin.Size = new System.Drawing.Size(46, 23);
            this.txt_SpecialCharMin.TabIndex = 7;
            this.txt_SpecialCharMin.Text = "0";
            this.txt_SpecialCharMin.TextChanged += new System.EventHandler(this.txt_SpecialCharMin_TextChanged);
            // 
            // txt_LowercaseMin
            // 
            this.txt_LowercaseMin.Location = new System.Drawing.Point(169, 74);
            this.txt_LowercaseMin.Name = "txt_LowercaseMin";
            this.txt_LowercaseMin.Size = new System.Drawing.Size(46, 23);
            this.txt_LowercaseMin.TabIndex = 8;
            this.txt_LowercaseMin.Text = "0";
            this.txt_LowercaseMin.TextChanged += new System.EventHandler(this.txt_LowercaseMin_TextChanged);
            // 
            // txt_NumbersMin
            // 
            this.txt_NumbersMin.Location = new System.Drawing.Point(169, 99);
            this.txt_NumbersMin.Name = "txt_NumbersMin";
            this.txt_NumbersMin.Size = new System.Drawing.Size(46, 23);
            this.txt_NumbersMin.TabIndex = 9;
            this.txt_NumbersMin.Text = "0";
            this.txt_NumbersMin.TextChanged += new System.EventHandler(this.txt_NumbersMin_TextChanged);
            // 
            // label_UppercaseMin
            // 
            this.label_UppercaseMin.AutoSize = true;
            this.label_UppercaseMin.Location = new System.Drawing.Point(135, 52);
            this.label_UppercaseMin.Name = "label_UppercaseMin";
            this.label_UppercaseMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_UppercaseMin.Size = new System.Drawing.Size(28, 15);
            this.label_UppercaseMin.TabIndex = 10;
            this.label_UppercaseMin.Text = "min";
            // 
            // label_LowercaseMin
            // 
            this.label_LowercaseMin.AutoSize = true;
            this.label_LowercaseMin.Location = new System.Drawing.Point(135, 77);
            this.label_LowercaseMin.Name = "label_LowercaseMin";
            this.label_LowercaseMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_LowercaseMin.Size = new System.Drawing.Size(28, 15);
            this.label_LowercaseMin.TabIndex = 11;
            this.label_LowercaseMin.Text = "min";
            // 
            // label_SpecialCharMin
            // 
            this.label_SpecialCharMin.AutoSize = true;
            this.label_SpecialCharMin.Enabled = false;
            this.label_SpecialCharMin.Location = new System.Drawing.Point(135, 127);
            this.label_SpecialCharMin.Name = "label_SpecialCharMin";
            this.label_SpecialCharMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_SpecialCharMin.Size = new System.Drawing.Size(28, 15);
            this.label_SpecialCharMin.TabIndex = 12;
            this.label_SpecialCharMin.Text = "min";
            // 
            // label_NumbersMin
            // 
            this.label_NumbersMin.AutoSize = true;
            this.label_NumbersMin.Location = new System.Drawing.Point(135, 102);
            this.label_NumbersMin.Name = "label_NumbersMin";
            this.label_NumbersMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_NumbersMin.Size = new System.Drawing.Size(28, 15);
            this.label_NumbersMin.TabIndex = 13;
            this.label_NumbersMin.Text = "min";
            // 
            // label_NumbersMax
            // 
            this.label_NumbersMax.AutoSize = true;
            this.label_NumbersMax.Location = new System.Drawing.Point(243, 102);
            this.label_NumbersMax.Name = "label_NumbersMax";
            this.label_NumbersMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_NumbersMax.Size = new System.Drawing.Size(30, 15);
            this.label_NumbersMax.TabIndex = 21;
            this.label_NumbersMax.Text = "max";
            // 
            // label_SpecialCharMax
            // 
            this.label_SpecialCharMax.AutoSize = true;
            this.label_SpecialCharMax.Enabled = false;
            this.label_SpecialCharMax.Location = new System.Drawing.Point(243, 127);
            this.label_SpecialCharMax.Name = "label_SpecialCharMax";
            this.label_SpecialCharMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_SpecialCharMax.Size = new System.Drawing.Size(30, 15);
            this.label_SpecialCharMax.TabIndex = 20;
            this.label_SpecialCharMax.Text = "max";
            // 
            // label_LowercaseMax
            // 
            this.label_LowercaseMax.AutoSize = true;
            this.label_LowercaseMax.Location = new System.Drawing.Point(243, 77);
            this.label_LowercaseMax.Name = "label_LowercaseMax";
            this.label_LowercaseMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_LowercaseMax.Size = new System.Drawing.Size(30, 15);
            this.label_LowercaseMax.TabIndex = 19;
            this.label_LowercaseMax.Text = "max";
            // 
            // label_UppercaseMax
            // 
            this.label_UppercaseMax.AutoSize = true;
            this.label_UppercaseMax.Location = new System.Drawing.Point(243, 52);
            this.label_UppercaseMax.Name = "label_UppercaseMax";
            this.label_UppercaseMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_UppercaseMax.Size = new System.Drawing.Size(30, 15);
            this.label_UppercaseMax.TabIndex = 18;
            this.label_UppercaseMax.Text = "max";
            // 
            // txt_NumbersMax
            // 
            this.txt_NumbersMax.Location = new System.Drawing.Point(277, 99);
            this.txt_NumbersMax.Name = "txt_NumbersMax";
            this.txt_NumbersMax.Size = new System.Drawing.Size(46, 23);
            this.txt_NumbersMax.TabIndex = 17;
            this.txt_NumbersMax.Text = "8";
            this.txt_NumbersMax.TextChanged += new System.EventHandler(this.txt_NumbersMax_TextChanged);
            // 
            // txt_LowercaseMax
            // 
            this.txt_LowercaseMax.Location = new System.Drawing.Point(277, 74);
            this.txt_LowercaseMax.Name = "txt_LowercaseMax";
            this.txt_LowercaseMax.Size = new System.Drawing.Size(46, 23);
            this.txt_LowercaseMax.TabIndex = 16;
            this.txt_LowercaseMax.Text = "8";
            this.txt_LowercaseMax.TextChanged += new System.EventHandler(this.txt_LowercaseMax_TextChanged);
            // 
            // txt_SpecialCharMax
            // 
            this.txt_SpecialCharMax.Enabled = false;
            this.txt_SpecialCharMax.Location = new System.Drawing.Point(277, 124);
            this.txt_SpecialCharMax.Name = "txt_SpecialCharMax";
            this.txt_SpecialCharMax.Size = new System.Drawing.Size(46, 23);
            this.txt_SpecialCharMax.TabIndex = 15;
            this.txt_SpecialCharMax.Text = "0";
            this.txt_SpecialCharMax.TextChanged += new System.EventHandler(this.txt_SpecialCharMax_TextChanged);
            // 
            // txt_UppercaseMax
            // 
            this.txt_UppercaseMax.Location = new System.Drawing.Point(277, 49);
            this.txt_UppercaseMax.Name = "txt_UppercaseMax";
            this.txt_UppercaseMax.Size = new System.Drawing.Size(46, 23);
            this.txt_UppercaseMax.TabIndex = 14;
            this.txt_UppercaseMax.Text = "8";
            this.txt_UppercaseMax.TextChanged += new System.EventHandler(this.txt_UppercaseMax_TextChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Generate.Location = new System.Drawing.Point(100, 155);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(188, 27);
            this.btn_Generate.TabIndex = 22;
            this.btn_Generate.Text = "GENERATE";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Password.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(12, 185);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.ReadOnly = true;
            this.txt_Password.Size = new System.Drawing.Size(360, 41);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.label_NumbersMax);
            this.Controls.Add(this.label_SpecialCharMax);
            this.Controls.Add(this.label_LowercaseMax);
            this.Controls.Add(this.label_UppercaseMax);
            this.Controls.Add(this.txt_NumbersMax);
            this.Controls.Add(this.txt_LowercaseMax);
            this.Controls.Add(this.txt_SpecialCharMax);
            this.Controls.Add(this.txt_UppercaseMax);
            this.Controls.Add(this.label_NumbersMin);
            this.Controls.Add(this.label_SpecialCharMin);
            this.Controls.Add(this.label_LowercaseMin);
            this.Controls.Add(this.label_UppercaseMin);
            this.Controls.Add(this.txt_NumbersMin);
            this.Controls.Add(this.txt_LowercaseMin);
            this.Controls.Add(this.txt_SpecialCharMin);
            this.Controls.Add(this.txt_UppercaseMin);
            this.Controls.Add(this.checkbox_Numbers);
            this.Controls.Add(this.checkbox_SpecialChar);
            this.Controls.Add(this.checkbox_Lowercase);
            this.Controls.Add(this.checkbox_Uppercase);
            this.Controls.Add(this.label_Length);
            this.Controls.Add(this.txt_Length);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "PasswordGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.Label label_Length;
        private System.Windows.Forms.CheckBox checkbox_Uppercase;
        private System.Windows.Forms.CheckBox checkbox_Lowercase;
        private System.Windows.Forms.CheckBox checkbox_SpecialChar;
        private System.Windows.Forms.CheckBox checkbox_Numbers;
        private System.Windows.Forms.TextBox txt_UppercaseMin;
        private System.Windows.Forms.TextBox txt_SpecialCharMin;
        private System.Windows.Forms.TextBox txt_LowercaseMin;
        private System.Windows.Forms.TextBox txt_NumbersMin;
        private System.Windows.Forms.Label label_UppercaseMin;
        private System.Windows.Forms.Label label_LowercaseMin;
        private System.Windows.Forms.Label label_SpecialCharMin;
        private System.Windows.Forms.Label label_NumbersMin;
        private System.Windows.Forms.Label label_NumbersMax;
        private System.Windows.Forms.Label label_SpecialCharMax;
        private System.Windows.Forms.Label label_LowercaseMax;
        private System.Windows.Forms.Label label_UppercaseMax;
        private System.Windows.Forms.TextBox txt_NumbersMax;
        private System.Windows.Forms.TextBox txt_LowercaseMax;
        private System.Windows.Forms.TextBox txt_SpecialCharMax;
        private System.Windows.Forms.TextBox txt_UppercaseMax;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_Password;
    }
}

