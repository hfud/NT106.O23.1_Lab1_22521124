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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void NumValue_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(NumValue.Text, out txt);
            if (isnumber == false && NumValue.Text != "" && NumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                NumValue.Text = "";
            }
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            switch (Int32.Parse(NumValue.Text))
            {
                case 0:
                    Result.Text = "Không";
                    break;
                case 1:
                    Result.Text = "Một";
                    break;
                case 2:
                    Result.Text = "Hai";
                    break;
                case 3:
                    Result.Text = "Ba";
                    break;
                case 4:
                    Result.Text = "Bốn";
                    break;
                case 5:
                    Result.Text = "Năm";
                    break;
                case 6:
                    Result.Text = "Sáu";
                    break;
                case 7:
                    Result.Text = "Bảy";
                    break;
                case 8:
                    Result.Text = "Tám";
                    break;
                case 9:
                    Result.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                    NumValue.Text = "";
                    break;
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
