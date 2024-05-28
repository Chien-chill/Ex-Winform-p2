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
    public partial class baitap1 : Form
    {
        public baitap1()
        {
            InitializeComponent();
        }
        private void baitap1_Load(object sender, EventArgs e)
        {

        }
        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void lblHoVaTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoVaTen.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {
            btnHoLot_Click(sender, e);
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnTen_Click(sender, e);
        }
    }
}
