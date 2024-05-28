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
    public partial class baitap22 : Form
    {
        public baitap22()
        {
            InitializeComponent();
        }

        public void btnNhap_Click(object sender, EventArgs e)
        {
            baitap22Input baitap22I = new baitap22Input();
            baitap22I.baitap22Reference = this;
            baitap22I.ShowDialog();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            foreach(int i in lstMang.Items)
            {
                Sum += i;
            }
            lblKQ.Text = Sum.ToString();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int Max = int.MinValue;
            int Min = int.MaxValue;
            foreach(int i in lstMang.Items)
            {
                if(i > Max)
                {
                    Max = i;
                }    
                if(i < Min)
                {
                    Min = i;
                }
            }    
            lblKQ.Text = $"Max= {Max.ToString()} và Min= {Min.ToString()}";
        }
        private void btnDemChan_Click(object sender, EventArgs e)
        {
            int count=0;
            foreach(int i in lstMang.Items)
            {
                if(i%2==0)
                {
                count++; 
                }
            }
            lblKQ.Text =$"Số lượng phần tử chẵn trong mảng: {count.ToString()}";
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            string Index=string.Empty;
            foreach(int i in lstMang.Items)
            { if(i%2==0)
                {
                    Index += lstMang.Items.IndexOf(i)+", ";
                }
            }
            Index=Index.Trim();
            Index = Index.TrimEnd(',');
            lblKQ.Text = $"Vị trí các phần tử chẵn: {Index}";
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            string Index = string.Empty;
            foreach (int i in lstMang.Items)
            {
                if (i % 2 != 0)
                {
                    Index += lstMang.Items.IndexOf(i) + ", ";
                }
            }
            Index = Index.Trim();
            Index = Index.TrimEnd(',');
            lblKQ.Text = $"Vị trí các phần tử lẻ: {Index}";
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int i in lstMang.Items)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            lblKQ.Text = $"Số lượng phần tử lẻ trong mảng: {count.ToString()}";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
