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
    public partial class baitap30Input : Form
    {
        public baitap30Input()
        {
            InitializeComponent();
        }
        public baitap30 baitap30Reference { get; set; }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool check = baitap30Reference.txtNhap.Text.Contains(txtChuoi.Text);
            if(check)
            {
                baitap30Reference.txtKQ.Text = baitap30Reference.txtNhap.Text.Replace(txtChuoi.Text, "");
            }
            else
            {
                MessageBox.Show("Chuỗi cần xóa không có trong dữ liệu !", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
