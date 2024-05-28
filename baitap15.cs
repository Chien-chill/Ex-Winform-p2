using DevExpress.Utils.DPI;
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
    public partial class baitap15 : Form
    {
        public baitap15()
        {
            InitializeComponent();
        }
        private int Sum(int x) 
        {
            int S=0;
            for(int i =1; i<=x;i++) 
            {
                S += i;
            }
            return S;
        }
        private double Sum2(int x) {
            double S=0;
            for(int i =1; i<=x; i++) {
                S += Math.Pow(i,i+1);
            }
            return S;
        }
        private void btnCN1_Click(object sender, EventArgs e)
        {
            txtKQ.Text = Sum(int.Parse(txtN.Text)).ToString();
        }

        private void btnCN2_Click(object sender, EventArgs e)
        {
            txtKQ.Text = Math.Pow(Sum(int.Parse(txtN.Text)),2).ToString();
        }

        private void btnCN3_Click(object sender, EventArgs e)
        {
            txtKQ.Text = Sum2(int.Parse(txtN.Text)).ToString();
        }

        private void btnCN4_Click(object sender, EventArgs e)
        {
            txtKQ.Text = ((double)Sum(int.Parse(txtN.Text))/ Sum2(int.Parse(txtN.Text))).ToString();
        }

        private void baitap15_Load(object sender, EventArgs e)
        {
            txtN.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
