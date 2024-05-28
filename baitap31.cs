using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_lab2
{
    public partial class baitap31 : Form
    {
        public baitap31()
        {
            InitializeComponent();
        }
        double tienThuong;
        private void btnQuaySo_Click(object sender, EventArgs e)
        {
          if(double.Parse(txtNguoiChoi.Text)<30)
            {
                MessageBox.Show("Tiền Người Chơi Phải Tối Thiểu 30", "Thông Báo", MessageBoxButtons.OK);
            }    
          else
            {
                txtNguoiChoi.Text = (double.Parse(txtNguoiChoi.Text)-30).ToString();
                txtMay.Text = (double.Parse(txtMay.Text) + 30).ToString();
            Random rd = new Random();
            int Luckynumber = rd.Next(0, 9);
            lblSoMayMan.Text = Luckynumber.ToString();
            switch ( Luckynumber)
            {
                case 0:
                    tienThuong += 10;
                    MessageBox.Show($"Tiền Thưởng Hiện Tại: {tienThuong} ","Thông Báo",MessageBoxButtons.OK);
                    break;
                case 9:
                    tienThuong += 30;
                    MessageBox.Show($"Tiền Thưởng Hiện Tại: {tienThuong} ", "Thông Báo", MessageBoxButtons.OK);
                    break;
                case 7:
                    tienThuong += (double)(100 + (int.Parse(txtMay.Text)*0.5));
                    txtMay.Text = (double.Parse(txtMay.Text) * 0.5).ToString();
                    MessageBox.Show($"Tiền Thưởng Hiện Tại: {tienThuong} ", "Thông Báo", MessageBoxButtons.OK);
                    break;
            }
            }

        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            tienThuong = 0;
        }
    }
}
