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
    public partial class Lab1_Bai7 : Form
    {
        public Lab1_Bai7()
        {
            InitializeComponent();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            string inp = input.Text.Trim();
            string[] data = inp.Split(',');

            // Kiểm tra tính hợp lệ của định dạng
            if (data.Length < 2 || !double.TryParse(data[1], out double _))
            {
                MessageBox.Show("Nhập sai format", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy tên sinh viên và danh sách điểm
            string studentName = data[0].Trim();
            double[] scores = data.Skip(1).Select(double.Parse).ToArray();

            // Xuất tên
            name.Text = studentName;

            // Xuất danh sách điểm
            for (int i = 0; i < scores.Length; i++)
            {
                point.Text += $"Môn {i + 1}: {scores[i]}   ";
            }

            // Điểm trung bình
            double averageScore = scores.Average();
            avg.Text = $"{averageScore}";

            // Điểm cao nhất và thấp nhất
            double maxScore = scores.Max();
            double minScore = scores.Min();
            max.Text = $"{maxScore}";
            min.Text = $"{minScore}";

            // Số môn đậu và rớt
            int passCount = scores.Count(score => score >= 5);
            int failCount = scores.Length - passCount;
            pass.Text = $"{passCount}";
            fail.Text = $"{failCount}";

            // Xếp loại
            string classification;
            if (averageScore >= 8 && scores.All(score => score >= 6.5))
                classification = "Giỏi";
            else if (averageScore >= 6.5 && scores.All(score => score >= 5))
                classification = "Khá";
            else if (averageScore >= 5 && scores.All(score => score >= 3.5))
                classification = "Trung bình";
            else if (averageScore >= 3.5 && scores.All(score => score >= 2))
                classification = "Yếu";
            else
                classification = "Kém";
            type.Text = classification;
        }
    }
}
