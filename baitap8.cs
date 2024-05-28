using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_lab2
{
    public partial class baitap8 : Form
    {
        public baitap8()
        {
            InitializeComponent();
        }
        private void baitap8_Load(object sender, EventArgs e)
        {

        }
        public bool check = false;
        private void btnGiai_Click(object sender, EventArgs e)
        {
            
            if(float.Parse(txtA.Text)==0)
            {
                this.Hide();
                baitap7 baitap7 = new baitap7();
                baitap7.baitap8Reference = this;
                baitap7.baitap7_Load(sender, e);
                baitap7.ShowDialog();
                this.Show();
            }
            else
            {
                double deta;
                deta = Math.Pow(double.Parse(txtB.Text), 2) - (4 * float.Parse(txtA.Text) * float.Parse(txtC.Text));
                if (deta < 0)
                {
                    txtX1.Text = "Vô Nghiệm";
                    txtX2.Text = "Vô Nghiệm";
                }
                else
                {
                    txtX1.Text = ((float)(-float.Parse(txtB.Text) + Math.Sqrt(deta)) / (float)(2 * float.Parse(txtA.Text))).ToString();
                    txtX2.Text = ((float)(-float.Parse(txtB.Text) - Math.Sqrt(deta)) / (float)(2 * float.Parse(txtA.Text))).ToString();
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
