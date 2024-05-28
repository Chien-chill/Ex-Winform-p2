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
    public partial class baitap7 : Form
    {
        public baitap7()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += baitap7_KeyDown;
        }
        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            txtKQ.Text ="Nghiệm = "+ (-float.Parse(txtHSB.Text)/float.Parse(txtHSA.Text)).ToString();
        }

        private void btnGiaiLai_Click(object sender, EventArgs e)
        {
            txtHSA.Text=string.Empty;
            txtHSB.Text=string.Empty;
            txtKQ.Text=string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baitap7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
        public baitap8 baitap8Reference { get; set; }
        public void baitap7_Load(object sender, EventArgs e)
        {
            if(baitap8Reference != null)
            {
                txtHSA.Text = baitap8Reference.txtB.Text;
                txtHSB.Text = baitap8Reference.txtC.Text;
            }
        }
    }
}
