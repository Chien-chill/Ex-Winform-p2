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
    public partial class baitap10 : Form
    {
        public baitap10()
        {
            InitializeComponent();
        }

        private void btnTinh1_Click(object sender, EventArgs e)
        {
            int Luongdien;
            Luongdien=int.Parse(txtMoi.Text)-int.Parse(txtCu.Text);   
            if(Luongdien <= nudDinhMuc.Value)
            {
                txtTongTien.Text=(Luongdien * int.Parse(txtGia1.Text)).ToString();
            }
            else
            {
                txtTongTien.Text=((nudDinhMuc.Value*int.Parse(txtGia1.Text))+((Luongdien-nudDinhMuc.Value)*int.Parse(txtGia2.Text))).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
