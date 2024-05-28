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
    public partial class baitap32 : Form
    {
        public baitap32()
        {
            InitializeComponent();
        }
        double tienthuong = 0;
        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(double.Parse(txtNguoiChoi.Text)<30 || txtNguoiChoi.Text=="")
            {
                MessageBox.Show("Số tiền đang có phải tối thiểu 30", "Hết tiền",MessageBoxButtons.OK);
            }
            else
            {
                txtNguoiChoi.Text = (double.Parse(txtNguoiChoi.Text) - 30).ToString();
                txtTienMay.Text = (double.Parse(txtTienMay.Text) + 30).ToString();
                Random rd = new Random();
                lbl1.Text = rd.Next(0, 7).ToString();
                lbl2.Text = rd.Next(0, 8).ToString();
                lbl3.Text = rd.Next(0, 10).ToString();
                if (lbl1.Text == 7.ToString())
                {
                    tienthuong = tienthuong + (100 + (0.5 * double.Parse(txtTienMay.Text)));
                    check = true;
                }
                if (lbl2.Text == 7.ToString())
                {
                    tienthuong = tienthuong + (30 + (0.1 * double.Parse(txtTienMay.Text)));
                    check = true;
                }
                if (lbl3.Text == 7.ToString())
                {
                    tienthuong = tienthuong + 10;
                    check = true;
                }
                if (check)
                {
                    MessageBox.Show($"Số tiền thưởng : {tienthuong}", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void baitap32_Load(object sender, EventArgs e)
        {
            txtTienMay.Text = 100.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            tienthuong = 0;
            baitap32_Load(sender, e);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
