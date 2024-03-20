using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22521124_NgoHongPhuc_Lab1
{
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private Dictionary<string, double> GiaChuan = new Dictionary<string, double>
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        private Dictionary<string, List<byte>> RapFilm = new Dictionary<string, List<byte>>
        {
            { "Đào, phở và piano", new List<byte> { 1, 2, 3 } },
            { "Mai", new List<byte> { 2, 3 } },
            { "Gặp lại chị bầu", new List<byte> { 1 } },
            { "Tarot", new List<byte> { 3 } }
        };

        private Dictionary<string, List<string>> LoaiGhe = new Dictionary<string, List<string>>
        {
            { "vé vớt", new List<string> { "A1", "A5", "C1", "C5" } },
            { "vé thường", new List<string> { "A2", "A3", "A4", "B1", "B5", "C2", "C3", "C4" } },
            { "vé VIP", new List<string> { "B2", "B3", "B4" } }
        };

        private Dictionary<string, double> GiaVe = new Dictionary<string, double>
        {
            { "vé vớt", 0.25 },
            { "vé thường", 1 },
            { "vé VIP", 2 }
        };

        private Dictionary<string, bool> Ghe = new Dictionary<string, bool>
        {
            { "A1", true }, { "A2", true }, { "A3", true }, { "A4", true }, { "A5", true },
            { "B1", true }, { "B2", true }, { "B3", true }, { "B4", true }, { "B5", true },
            { "C1", true }, { "C2", true }, { "C3", true }, { "C4", true }, { "C5", true }
        };

        private void film_SelectedIndexChanged(object sender, EventArgs e)
        {
            theater.Text = "";
            string selectedFilm = film.SelectedItem.ToString();
            List<byte> rapList = RapFilm[selectedFilm];    
            theater.Items.Clear();
            foreach (byte rap in rapList)
                theater.Items.Add(rap);
        }

        private void theater_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilm = film.SelectedItem.ToString();
            byte selectedRap = Convert.ToByte(theater.SelectedItem);
            if (LoaiGhe.ContainsKey(selectedFilm))
            {
                List<string> gheList = LoaiGhe[selectedFilm];
                HangGhe.Items.Clear();
                foreach (string ghe in gheList)
                {
                    if (Ghe.ContainsKey(ghe) && Ghe[ghe])
                    {
                        HangGhe.Items.Add(ghe);
                    }
                }
            }
        }

        private void DatVe_Click(object sender, EventArgs e)
        {
            if (film.SelectedItem == null || theater.SelectedItem == null || HangGhe.CheckedItems.Count == 0 || name.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = name.Text;
            string selectedFilm = film.SelectedItem.ToString();
            byte selectedRap = Convert.ToByte(theater.SelectedItem);
            List<string> selectedSeats = new List<string>();
            foreach (object item in HangGhe.CheckedItems)
            {
                selectedSeats.Add(item.ToString());
            }

            // Tính tiền
            double totalPayment = 0;
            foreach (string seat in selectedSeats)
            {
                string seatType = LoaiGhe.FirstOrDefault(x => x.Value.Contains(seat)).Key;
                double seatPrice = GiaVe[seatType] * GiaChuan[selectedFilm];
                totalPayment += seatPrice;
            }

            // Xuất thông tin
            string receipt = $"Tên khách hàng: {customerName}\nVé đã chọn:\n";
            foreach (string seat in selectedSeats)
            {
                receipt += $"{seat}  ";
            }
            receipt += $"\nFilm: {selectedFilm}\nPhòng chiếu: {selectedRap}\nTổng tiền: {totalPayment} VNĐ";
            MessageBox.Show(receipt, "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}