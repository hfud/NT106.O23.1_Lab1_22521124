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
    public partial class Lab1_Bai6 : Form
    {
        public Lab1_Bai6()
        {
            InitializeComponent();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            DateTime birthday = new DateTime();
            try
            {
                Console.WriteLine(birth.Text);
                birthday = DateTime.Parse(birth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập theo định dạng MM/DD/YYYY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                birth.Text = "";
            }
            switch (birthday.Month)
            {
                case 1:
                    if (birthday.Day > 0 && birthday.Day <= 20)
                    {
                        zodiac.Text = "Ma Kết";
                    }
                    else if (birthday.Day >= 21 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Bảo Bình";
                    }
                    break;
                case 2:
                    if (birthday.Day > 0 && birthday.Day <= 19)
                    {
                        zodiac.Text = "Bảo Bình";
                    }
                    else if (birthday.Day >= 20 && birthday.Day <= 29)
                    {
                        zodiac.Text = "Song Ngư";
                    }
                    break;
                case 3:
                    if (birthday.Day > 0 && birthday.Day <= 20)
                    {
                        zodiac.Text = "Song Ngư";
                    }
                    else if (birthday.Day >= 21 && birthday.Day <= 30)
                    {
                        zodiac.Text = "Bạch Dương";
                    }
                    break;
                case 4:
                    if (birthday.Day > 0 && birthday.Day <= 20)
                    {
                        zodiac.Text = "Bạch Dương";
                    }
                    else if (birthday.Day >= 21 && birthday.Day <= 30)
                    {
                        zodiac.Text = "Kim Ngưu";
                    }
                    break;
                case 5:
                    if (birthday.Day > 0 && birthday.Day <= 21)
                    {
                        zodiac.Text = "Kim Ngưu";
                    }
                    else if (birthday.Day >= 22 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Song Tử";
                    }
                    break;
                case 6:
                    if (birthday.Day > 0 && birthday.Day <= 21)
                    {
                        zodiac.Text = "Song Tử";
                    }
                    else if (birthday.Day >= 22 && birthday.Day <= 30)
                    {
                        zodiac.Text = "Cự Giải";
                    }
                    break;
                case 7:
                    if (birthday.Day > 0 && birthday.Day <= 22)
                    {
                        zodiac.Text = "Cự Giải";
                    }
                    else if (birthday.Day >= 23 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Sư Tử";
                    }
                    break;
                case 8:
                    if (birthday.Day > 0 && birthday.Day <= 22)
                    {
                        zodiac.Text = "Sư Tử";
                    }
                    else if (birthday.Day >= 23 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Xử Nữ";
                    }
                    break;
                case 9:
                    if (birthday.Day > 0 && birthday.Day <= 23)
                    {
                        zodiac.Text = "Xử Nữ";
                    }
                    else if (birthday.Day >= 24 && birthday.Day <= 30)
                    {
                        zodiac.Text = "Thiên Bình";
                    }
                    break;
                case 10:
                    if (birthday.Day > 0 && birthday.Day <= 23)
                    {
                        zodiac.Text = "Thiên Bình";
                    }
                    else if (birthday.Day >= 24 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Thần Nông";
                    }
                    break;
                case 11:
                    if (birthday.Day > 0 && birthday.Day <= 22)
                    {
                        zodiac.Text = "Thần Nông";
                    }
                    else if (birthday.Day >= 23 && birthday.Day <= 30)
                    {
                        zodiac.Text = "Nhân Mã";
                    }
                    break;
                case 12:
                    if (birthday.Day > 0 && birthday.Day <= 21)
                    {
                        zodiac.Text = "Nhân Mã";
                    }
                    else if (birthday.Day >= 22 && birthday.Day <= 31)
                    {
                        zodiac.Text = "Ma Kết";
                    }
                    break;
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            birth.Text = zodiac.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
