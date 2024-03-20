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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void numA_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(numA.Text, out txt);
            if (isnumber == false && numA.Text != "" && numA.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                numA.Text = "";
            }
        }

        private void numB_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(numB.Text, out txt);
            if (isnumber == false && numB.Text != "" && numB.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                numB.Text = "";
            }
        }

        private string BangCuuChuong(int x)
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += $"{x} * {i} = {x * i}\r\n";
            }
            result += "\r\n";
            return result;
        }

        private long GiaiThua(int x)
        {
            return (x == 0) ? 1 : x * GiaiThua(x - 1);
        }

        private long TongMu(int a, int b)
        {
            long sum = 0;
            for (int i = 1; i <= b; i++)
            {
                sum += (long)Math.Pow(a, i);
            }
            return sum;
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(numA.Text);
            int b = Int32.Parse(numB.Text);
            if (option.Text == "Bảng cửu chương")
            {
                int num = b - a;
                Result.Text = BangCuuChuong(num);
            }
            if (option.Text == "Tính toán giá trị")
            {
                int num = a - b;
                if (num >= 0)
                {
                    long factorial = GiaiThua(num);
                    Result.Text = $"(A - B)! = {factorial}\r\n";
                }
                else
                    MessageBox.Show("Vui lòng nhập A >= B để tính (A - B)!", "Warning!");
                long sum = TongMu(a, b);
                Result.Text += $"Tổng S = {sum}";
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            numA.Text = numB.Text = Result.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
