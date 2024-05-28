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
    public partial class baitap17 : Form
    {
        public baitap17()
        {
            InitializeComponent();
        }

        public int MaHoaKyTu(char Kytu)
        {
            return (int)Kytu;
        }
        public char GiaiMaKyTu(int key)
        {
            return (char)key;
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            txtMaHoa.Text=string.Empty;
            string str = txtChuoiNhap.Text;
            foreach(char ch in str)
            {
                txtMaHoa.Text += MaHoaKyTu(ch) + " ";
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            txtGiaiMa.Text=string.Empty;
            string str = txtChuoiNhap.Text;
            foreach(int key in str)
            {
                txtGiaiMa.Text += GiaiMaKyTu(key);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
