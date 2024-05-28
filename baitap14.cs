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
    public partial class baitap14 : Form
    {
        public baitap14()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += baitap14_KeyDown;
        }
        private void btnTH_Click(object sender, EventArgs e)
        {
            txtN.Focus();
            lblKQ.Text=string.Empty;
            int temp = int.Parse(txtN.Text);
            for (int i = 1; i <= temp; i++)
            {
                if(temp % i ==0)
                {
                    lblKQ.Text += i.ToString() + " ";
                }    
            }
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baitap14_Load(object sender, EventArgs e)
        {
            txtN.Focus();
        }

        private void baitap14_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTH_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
