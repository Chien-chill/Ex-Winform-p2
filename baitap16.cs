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
    public partial class baitap16 : Form
    {
        public baitap16()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            txtAmLich.Text = string.Empty;
            int a=-1, b=-1;
            a = int.Parse(txtDuongLich.Text)%10 ;
            b = int.Parse(txtDuongLich.Text)%12;
            switch (a)
            {
                case 0: txtAmLich.Text = "Canh"; break;
                case 1: txtAmLich.Text = "Tân"; break;
                case 2: txtAmLich.Text = "Nhâm"; break;
                case 3: txtAmLich.Text = "Quý"; break;
                case 4: txtAmLich.Text = "Giáp"; break;
                case 5: txtAmLich.Text = "Ất"; break;
                case 6: txtAmLich.Text = "Bính"; break;
                case 7: txtAmLich.Text = "Đinh"; break;
                case 8: txtAmLich.Text = "Mậu"; break;
                case 9: txtAmLich.Text = "Kỷ"; break;
            }
            switch (b)
            {
                case 0: txtAmLich.Text += " Thân"; break;
                case 1: txtAmLich.Text += " Dậu"; break;
                case 2: txtAmLich.Text += " Tuất"; break;
                case 3: txtAmLich.Text += " Hợi"; break;
                case 4: txtAmLich.Text += " Tý"; break;
                case 5: txtAmLich.Text += " Sửu"; break;
                case 6: txtAmLich.Text += " Dần"; break;
                case 7: txtAmLich.Text += " Mão"; break;
                case 8: txtAmLich.Text += " Thìn"; break;
                case 9: txtAmLich.Text += " Tỵ"; break;
                case 10: txtAmLich.Text += " Ngọ"; break;
                case 11: txtAmLich.Text += " Mùi"; break;
            }
        }

        private void baitap16_Load(object sender, EventArgs e)
        {
            txtDuongLich.Focus();
        }
    }
}
