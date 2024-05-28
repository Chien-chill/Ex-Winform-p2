using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_lab2
{
    public partial class baitap6 : Form
    {
        public baitap6()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += baitap6_KeyDown;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lblKQ.Text = (float.Parse(txtY.Text)+float.Parse(txtY.Text)).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            lblKQ.Text = (float.Parse(txtX.Text)-float.Parse(txtY.Text)).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lblKQ.Text = (float.Parse(txtX.Text)*float.Parse(txtY.Text)).ToString();
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            lblKQ.Text = ((Math.Pow(double.Parse(txtX.Text),2))).ToString();                                               
        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            lblKQ.Text = ((Math.Pow(double.Parse(txtX.Text), 3))).ToString();
        }

        private void btnNBP_Click(object sender, EventArgs e)
        {
            lblKQ.Text = ((Math.Pow(double.Parse(txtX.Text), 0.5))).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void baitap6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
