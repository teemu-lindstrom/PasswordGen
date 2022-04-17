using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Validator();
        }
        int defaultLength = 8;
        int length;
        int uppercaseMin;
        int uppercaseMax;
        int lowercaseMin;
        int lowercaseMax;
        int specialMin;
        int specialMax;
        int numbersMin;
        int numbersMax;

        int minCount;
        int maxCount;

        private void Validator()
        {


            try
            {
                length = String.IsNullOrWhiteSpace(txt_Length.Text) ? defaultLength : Int32.Parse(txt_Length.Text);
                uppercaseMin = String.IsNullOrWhiteSpace(txt_UppercaseMin.Text) ? 0 : Int32.Parse(txt_UppercaseMin.Text);
                uppercaseMax = String.IsNullOrWhiteSpace(txt_UppercaseMax.Text) ? length : Int32.Parse(txt_UppercaseMax.Text);
                lowercaseMin = String.IsNullOrWhiteSpace(txt_LowercaseMin.Text) ? 0 : Int32.Parse(txt_LowercaseMin.Text);
                lowercaseMax = String.IsNullOrWhiteSpace(txt_LowercaseMax.Text) ? length : Int32.Parse(txt_LowercaseMax.Text);
                specialMin = String.IsNullOrWhiteSpace(txt_SpecialCharMin.Text) ? 0 : Int32.Parse(txt_SpecialCharMin.Text);
                specialMax = String.IsNullOrWhiteSpace(txt_SpecialCharMax.Text) ? length : Int32.Parse(txt_SpecialCharMax.Text);
                numbersMin = String.IsNullOrWhiteSpace(txt_NumbersMin.Text) ? 0 : Int32.Parse(txt_NumbersMin.Text);
                numbersMax = String.IsNullOrWhiteSpace(txt_NumbersMax.Text) ? length : Int32.Parse(txt_NumbersMax.Text);

                if (length > 20) { txt_Length.Text = "20"; }
                if (uppercaseMax < uppercaseMin) { txt_UppercaseMin.Text = txt_UppercaseMax.Text; }
                if (lowercaseMax < lowercaseMin) { txt_LowercaseMin.Text = txt_LowercaseMax.Text; }
                if (specialMax < specialMin) { txt_SpecialCharMin.Text = txt_SpecialCharMax.Text; }
                if (numbersMax < numbersMin) { txt_NumbersMin.Text = txt_NumbersMax.Text; }

                if (uppercaseMax > length) { txt_UppercaseMax.Text = txt_Length.Text; }
                if (lowercaseMax > length) { txt_LowercaseMax.Text = txt_Length.Text; }
                if (specialMax > length) { txt_SpecialCharMax.Text = txt_Length.Text; }
                if (numbersMax > length) { txt_NumbersMax.Text = txt_Length.Text; }

                minCount = uppercaseMin + lowercaseMin + specialMin + numbersMin;
                maxCount = uppercaseMax + lowercaseMax + specialMax + numbersMax;

                if (minCount <= length && maxCount >= length)
                {
                    btn_Generate.Enabled = true;
                }
                else
                {
                    btn_Generate.Enabled = false;
                }

                    
            }
            catch
            {
                btn_Generate.Enabled = false;

            }

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowers = "abcdefghijklmnopqrstuvWxyz";
            string specials = @"@%+\/'!#$^?:,(){}[]~-_.";
            string numbers = "1234567890";
            string pwString = "";
            Random rnd = new Random();
            int upperCount = 0;
            int lowerCount = 0;
            int specialCount = 0;
            int numberCount = 0;
            List<string> pool = new List<String>();

            for (int i = 0; i < uppercaseMin; i++)
            {
                pwString += uppers[rnd.Next(0, uppers.Length)];
                upperCount++;
            }
            for (int i = 0; i < lowercaseMin; i++)
            {
                pwString += lowers[rnd.Next(0, lowers.Length)];
                lowerCount++;
            }
            for (int i = 0; i < specialMin; i++)
            {
                pwString += specials[rnd.Next(0, specials.Length)];
                specialCount++;
            }
            for (int i = 0; i < numbersMin; i++)
            {
                pwString += numbers[rnd.Next(0, numbers.Length)];
                numberCount++;
            }

            if (upperCount < uppercaseMax) { pool.Add("upper"); }
            if (lowerCount < lowercaseMax) { pool.Add("lower"); }
            if (specialCount < specialMax) { pool.Add("special"); }
            if (numberCount < numbersMax) { pool.Add("number"); }           
            while (pwString.Length < length)
            {
                string type = pool[rnd.Next(0, pool.Count())];

                switch (type)
                {
                    case "upper":
                        pwString += Char.ConvertFromUtf32(rnd.Next(65, 91));
                        upperCount++;
                        break;

                    case "lower":
                        pwString += Char.ConvertFromUtf32(rnd.Next(97, 123));
                        lowerCount++;
                        break;

                    case "special":
                        pwString += Char.ConvertFromUtf32(rnd.Next(33, 48));
                        specialCount++;
                        break;

                    case "number":
                        pwString += Char.ConvertFromUtf32(rnd.Next(48, 58));
                        numberCount++;
                        break;
                }
                if (upperCount >= uppercaseMax) { pool.Remove("upper"); }
                if (lowerCount >= lowercaseMax) { pool.Remove("lower"); }
                if (specialCount >= specialMax) { pool.Remove("special"); }
                if (numberCount >= numbersMax) { pool.Remove("number"); }
            }
            char[] pwArray = pwString.ToCharArray();
            for (int i = 0; i < pwString.Length; i++)
            {
                int randomIndex = rnd.Next(0, pwString.Length);
                char value = pwArray[randomIndex];
                pwArray[randomIndex] = pwArray[i];
                pwArray[i] = value;
            }
            pwString =  new string(pwArray);
            txt_Password.Text = pwString;
        }

        private void txt_Length_TextChanged(object sender, EventArgs e)
        {
            if (checkbox_Uppercase.Checked) { txt_UppercaseMax.Text = txt_Length.Text; };
            if (checkbox_Lowercase.Checked) { txt_LowercaseMax.Text = txt_Length.Text; };
            if (checkbox_SpecialChar.Checked) { txt_SpecialCharMax.Text = txt_Length.Text; };
            if (checkbox_Numbers.Checked) { txt_NumbersMax.Text = txt_Length.Text; };
            Validator();
            

        }

        private void txt_UppercaseMin_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_LowercaseMin_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_SpecialCharMin_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_NumbersMin_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_UppercaseMax_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_LowercaseMax_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_SpecialCharMax_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void txt_NumbersMax_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        private void checkbox_Uppercase_CheckedChanged(object sender, EventArgs e)
        {
            label_UppercaseMin.Enabled = !label_UppercaseMin.Enabled;
            label_UppercaseMax.Enabled = !label_UppercaseMax.Enabled;
            txt_UppercaseMin.Enabled = !txt_UppercaseMin.Enabled;
            txt_UppercaseMax.Enabled = !txt_UppercaseMax.Enabled;
            txt_UppercaseMin.Text = "0";
            txt_UppercaseMax.Text = checkbox_Uppercase.Checked ? txt_Length.Text : "0";
        }

        private void checkbox_Lowercase_CheckedChanged(object sender, EventArgs e)
        {
            label_LowercaseMin.Enabled = !label_LowercaseMin.Enabled;
            label_LowercaseMax.Enabled = !label_LowercaseMax.Enabled;
            txt_LowercaseMin.Enabled = !txt_LowercaseMin.Enabled;
            txt_LowercaseMax.Enabled = !txt_LowercaseMax.Enabled;
            txt_LowercaseMin.Text = "0";
            txt_LowercaseMax.Text = checkbox_Lowercase.Checked ? txt_Length.Text : "0";
        }

        private void checkbox_SpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            label_SpecialCharMin.Enabled = !label_SpecialCharMin.Enabled;
            label_SpecialCharMax.Enabled = !label_SpecialCharMax.Enabled;
            txt_SpecialCharMin.Enabled = !txt_SpecialCharMin.Enabled;
            txt_SpecialCharMax.Enabled = !txt_SpecialCharMax.Enabled;
            txt_SpecialCharMin.Text = "0";
            txt_SpecialCharMax.Text = checkbox_SpecialChar.Checked ? txt_Length.Text : "0";
        }

        private void checkbox_Numbers_CheckedChanged(object sender, EventArgs e)
        {
            label_NumbersMin.Enabled = !label_NumbersMin.Enabled;
            label_NumbersMax.Enabled = !label_NumbersMax.Enabled;
            txt_NumbersMin.Enabled = !txt_NumbersMin.Enabled;
            txt_NumbersMax.Enabled = !txt_NumbersMax.Enabled;
            txt_NumbersMin.Text = "0";
            txt_NumbersMax.Text = checkbox_Numbers.Checked ? txt_Length.Text : "0";

        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.SelectAll();
            if (!String.IsNullOrEmpty(txt_Password.Text)) 
            {
                
                Clipboard.SetText(txt_Password.Text);
            }     
        }

    }
}
