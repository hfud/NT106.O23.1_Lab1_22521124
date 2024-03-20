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
    public partial class Lab1_Bai8 : Form
    {
        public Lab1_Bai8()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            list.Items.Add(input.Text);
            input.Text = "";
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            if (list.Items.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(list.Items.Count);
                result.Text = list.Items[index].ToString();
            }
            else
            {
                MessageBox.Show("Danh sách món đang trống", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            input.Text = result.Text = "";
            list.Items.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
