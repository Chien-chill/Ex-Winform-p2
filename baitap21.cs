using DevExpress.Data.Platform.Compatibility;
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
    public partial class baitap21 : Form
    {
        public baitap21()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < int.Parse(txtN.Text); i++)
            {
                int number = rd.Next(1, 30);
                cbRandom.Items.Add(number.ToString());
            }
        }

        private void cbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDaySo.Items.Clear();
            for (int i = 1; i < int.Parse(cbRandom.Text); i++)
            {
                if (int.Parse(cbRandom.Text) % i == 0)
                {
                    lstDaySo.Items.Add(i);
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int i in lstDaySo.Items)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show($"Số Lượng Ước Số Chẵn = {count}", "Thông báo", MessageBoxButtons.OK);
        }
        private bool SNT(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if(n==2 || n==1)
                {
                    return true;
                }
                else if(n%i==0)
                return false;
            }
            return true;
        }
        private void btnSNT_Click(object sender, EventArgs e)
        {
            string listSNT = string.Empty;
            foreach(int i in lstDaySo.Items)
            {
                if(SNT(i))
                {
                    listSNT += i.ToString() + ", ";
                }
            }
            listSNT = listSNT.TrimEnd();
            listSNT = listSNT.TrimEnd(',');
            MessageBox.Show($"Số Nguyên Tố Trong Ước Số Trên: {listSNT}", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int Sum=0;
            foreach(int i in lstDaySo.Items)
            { Sum += i; }
            MessageBox.Show($"Tổng Các Ước Số Trên: {Sum}", "Thông Báo", MessageBoxButtons.OK);
        }
    }
}
