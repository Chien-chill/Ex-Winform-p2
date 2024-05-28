using DevExpress.DirectX.Common.DirectWrite;
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
    public partial class baitap19 : Form
    {
        public baitap19()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lstLopA.Items.Add(txtInput.Text);
            txtInput.Text = string.Empty;
            txtInput.Focus();
        }

        private void baitap19_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(sender,e);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            foreach (string item in lstLopA.Items)
            {
                Sum += double.Parse(item);
            }
            MessageBox.Show($"Tổng dãy số trên = {Sum}", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            lstLopA.Items.RemoveAt(0);
            lstLopA.Items.RemoveAt(lstLopA.Items.Count-1);
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            lstLopA.Items.RemoveAt(lstLopA.SelectedIndex);
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<lstLopA.Items.Count;i++)
            {
                lstLopA.Items[i] = (double.Parse(lstLopA.Items[i].ToString())+2);
            }    
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                lstLopA.Items[i] = Math.Pow((double.Parse(lstLopA.Items[i].ToString())),2);
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                lstLopA.SetSelected(i, false);
                if (double.Parse(lstLopA.Items[i].ToString())%2==0)
                {
                    lstLopA.SetSelected(i,true);
                }    
            }
        }

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                lstLopA.SetSelected(i, false);
                if (double.Parse(lstLopA.Items[i].ToString()) % 2 != 0)
                {
                    lstLopA.SetSelected(i, true);
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

