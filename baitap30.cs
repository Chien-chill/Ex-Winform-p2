using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_lab2
{
    public partial class baitap30 : Form
    {
        public baitap30()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = true;
                }
            }
            txtNhap.Focus();   
        }
        private void EnableBtnOff()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text != "Nhập Liệu" && control.Text != "Kết Thúc")
                {
                    ((Button)control).Enabled = false;
                }
            }
        }
        private void baitap30_Load(object sender, EventArgs e)
        {

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnHoa.Enabled = true;
            txtKQ.Text = "Chữ hoa là: "+ txtNhap.Text.ToUpper();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnThuong.Enabled = true;
            txtKQ.Text = "Chữ thường là: "+ txtNhap.Text.ToLower();
        }

        private void btnDemThuong_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnDemThuong.Enabled = true;
            int count =0;
            foreach (char c in txtNhap.Text) {
                if(char.IsLower(c)) count++;
            }
            txtKQ.Text = "Số kí tự thường là" + count.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            baitap30Input baitap30I = new baitap30Input();
            baitap30I.baitap30Reference = this;                                                                                                                                                                                                                                                 
            baitap30I.ShowDialog();
        }

        private void btnDemHoa_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnDemHoa.Enabled = true;
            int count = 0;
            foreach (char c in txtNhap.Text)
            {
                if (char.IsUpper(c)) count++;
            }
            txtKQ.Text = "Số kí tự hoa là " + count.ToString();
        }

        private void btnInTu_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnInTu.Enabled = true;
            txtKQ.Text=string.Empty;
            foreach (char c in txtNhap.Text)
            {
                txtKQ.Text += c + "\r\n";
            }
        }

        private void btnDemTu_Click(object sender, EventArgs e)
        {
            EnableBtnOff();
            btnDemTu.Enabled = true;
            int count = 0;
            foreach (char c in txtNhap.Text)
            {
                count++;
            }
            txtKQ.Text = "Số lượng từ : " + count;
        }

        private void btnInNguyenAm_Click(object sender, EventArgs e)
        {
            string KQNguyenAm = string.Empty;
            string KQPhuAm = string.Empty;
            string[] NguyenAm = { "a", "ă", "â","e","ê","i","o","ô","ơ","u","ư","y"};
            string[] PhuAm = { "b", "c", "ch", "d", "đ", "g", "gh", "h", "k", "kh", "l", "m", "n", "ng", "ngh", "nh", "p", "ph", "q", "r", "s", "t", "th", "tr", "v", "x", "gi", "qu" };
            string input = txtNhap.Text.ToLower();
            foreach (string c in NguyenAm) {
                if (input.Contains(c))
                {
                    KQNguyenAm += c +" ";
                }
            }
            foreach (string c in PhuAm)
            {
                if (input.Contains(c))
                {
                    KQPhuAm += c +" ";
                }
            }
            txtKQ.Text = "Nguyên Âm : " + KQNguyenAm +"\r\n" + "Phụ Âm : " + KQPhuAm;
        }

        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            Regex trimmer = new Regex(@"\s\s+");
            txtKQ.Text = txtNhap.Text.Trim();
            txtKQ.Text = trimmer.Replace(txtNhap.Text," ");
        }
    }
}
