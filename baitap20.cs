using DevExpress.Data.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace baitap_lab2
{
    public partial class baitap20 : Form
    {
        public baitap20()
        {
            InitializeComponent();
        }

        private void baitap20_Load(object sender, EventArgs e)
        {

        }
        public void Sum()
        {
            lblSumNhom1.Text = "Tổng số : "+ lstNhom1.Items.Count.ToString();
            lblSumNhom2.Text = "Tổng số : " + lstNhom2.Items.Count.ToString();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtName.Text==string.Empty)
            {
                MessageBox.Show("Chưa Nhập Tên Sinh Viên");
            }
            else
            {

            if(cbNhom.Text == "Nhóm 1")
            {
                lstNhom1.Items.Add(txtName.Text);
            }
            else
            {
                lstNhom2.Items.Add(txtName.Text);
            }
           Sum();
            }
        }

        private void btnQua2_Click(object sender, EventArgs e)
        {
            bool check = false;
            for(int i = 0;i<lstNhom1.Items.Count;i++)
            {
                if(lstNhom1.GetSelected(i))
                {
                    check = true;
                    break;
                }
            }
            if(check)
            {
            lstNhom2.Items.Add(lstNhom1.SelectedItem);
            lstNhom1.Items.RemoveAt(lstNhom1.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đối tượng");
            }
            Sum();

        }

        private void btnQua1_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < lstNhom2.Items.Count; i++)
            {
                if (lstNhom2.GetSelected(i))
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                lstNhom1.Items.Add(lstNhom2.SelectedItem);
                lstNhom2.Items.RemoveAt(lstNhom2.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đối tượng");
            }
            Sum();
            
        }

        private void btnQuaAll2_Click(object sender, EventArgs e)
        {
            for(int i = 0;i< lstNhom1.Items.Count;i++)
            {
                lstNhom2.Items.Add(lstNhom1.Items[i]);
            }
                lstNhom1.Items.Clear();
            Sum();
        }

        private void btnQuaAll1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNhom2.Items.Count; i++)
            {
                lstNhom1.Items.Add(lstNhom2.Items[i]);
            }
                lstNhom2.Items.Clear();
            Sum();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNhom1.Items.Count; i++)
            {
                if (lstNhom1.GetSelected(i))
                {
                    lstNhom1.Items.RemoveAt(lstNhom1.SelectedIndices[0]);
                    break;
                }
            }
            for (int i = 0; i < lstNhom2.Items.Count; i++)
            {
                if (lstNhom2.GetSelected(i))
                {
                    lstNhom2.Items.RemoveAt(lstNhom2.SelectedIndices[0]);
                    break;
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
