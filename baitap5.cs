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
    public partial class baitap5 : Form
    {
        public baitap5()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (float.Parse(txtSH1.Text) + float.Parse(txtSH2.Text)).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (float.Parse(txtSH1.Text) - float.Parse(txtSH2.Text)).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (float.Parse(txtSH1.Text) * float.Parse(txtSH2.Text)).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtKQ.Text = ((float)(float.Parse(txtSH1.Text) / float.Parse(txtSH2.Text))).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
