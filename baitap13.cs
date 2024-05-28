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
    public partial class baitap13 : Form
    {
        public baitap13()
        {
            InitializeComponent();
        }
        private int GiaiThua(int n)
        {
            int GT=1;
             for(int i = n; i >0 ; i--)
            {
                GT *=i;
            }
             return GT;
        }
        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            txtKQ.Text = GiaiThua(int.Parse(txtN.Text)).ToString();
        }

        private void btnGiaiThuaChia_Click(object sender, EventArgs e)
        {
            int a = GiaiThua(int.Parse(txtN.Text));
            int b = GiaiThua((int.Parse(txtN.Text) + 1));
            txtKQ.Text = ((float)a/b).ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
