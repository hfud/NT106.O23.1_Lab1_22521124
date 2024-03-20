using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22521124_NgoHongPhuc_Lab1
{
    public partial class Lab1_Bai31 : Form
    {
        public Lab1_Bai31()
        {
            InitializeComponent();
        }

        private void NumValue_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = double.TryParse(NumValue.Text, out txt);
            if (isnumber == false && NumValue.Text != "" && NumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                NumValue.Text = "";
            }
        }

        private string NumberToWords(long number)
        {
            if (number == 0)
                return "Không";

            string words = "", sign = "";

            if (number < 0)
            {
                sign = "Âm ";
                number = -number;
            }

            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] powersOfTen = { "", "Mươi", "Trăm", "Nghìn", "Mươi", "Trăm", "Triệu", "Mươi", "Trăm", "Tỷ", "Mươi", "Trăm", "Nghìn" };

            int powerIndex = 0;

            while (number > 0)
            {
                int group = (int)(number % 1000);
                if (group > 0)
                {
                    string groupWords = "";
                    int hundreds = group / 100;
                    int tensUnits = group % 100;
                    if (hundreds > 0)
                    {
                        groupWords += ones[hundreds] + " Trăm ";
                    }
                    if (tensUnits > 0)
                    {
                        if (tensUnits < 20)
                        {
                            groupWords += ones[tensUnits];
                        }
                        else
                        {
                            groupWords += ones[tensUnits / 10] + " mươi " + ones[tensUnits % 10];
                        }
                    }
                    groupWords += " " + powersOfTen[powerIndex];
                    words = groupWords + " " + words;
                }
                number /= 1000;
                powerIndex += 3;
            }
            words = sign + words;
            return words.Trim();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            long number;
            if (long.TryParse(NumValue.Text, out number))
            {
                Result.Text = NumberToWords(number);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            NumValue.Text = Result.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
