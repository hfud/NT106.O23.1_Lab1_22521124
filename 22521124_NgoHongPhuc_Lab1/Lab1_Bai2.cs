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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void FirstNumValue_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = double.TryParse(FirstNumValue.Text, out txt);
            if (isnumber == false && FirstNumValue.Text != "" && FirstNumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                FirstNumValue.Text = "";
            }
        }

        private void SecondNumValue_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = double.TryParse(SecondNumValue.Text, out txt);
            if (isnumber == false && SecondNumValue.Text != "" && SecondNumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                SecondNumValue.Text = "";
            }
        }

        private void ThirdNumValue_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = double.TryParse(ThirdNumValue.Text, out txt);
            if (isnumber == false && ThirdNumValue.Text != "" && ThirdNumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                ThirdNumValue.Text = "";
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            double NumValue1, NumValue2, NumValue3, Max, Min;
            NumValue1 = Convert.ToDouble(FirstNumValue.Text);
            NumValue2 = Convert.ToDouble(SecondNumValue.Text);
            NumValue3 = Convert.ToDouble(ThirdNumValue.Text);
            Max = Math.Max(NumValue1, Math.Max(NumValue2, NumValue3));
            Min = Math.Min(NumValue1, Math.Min(NumValue2, NumValue3));
            MaxValue.Text = Convert.ToString(Max);
            MinValue.Text = Convert.ToString(Min);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            FirstNumValue.Text = SecondNumValue.Text = ThirdNumValue.Text = MaxValue.Text = MinValue.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
