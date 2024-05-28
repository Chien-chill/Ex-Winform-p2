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
    public partial class baitap23 : Form
    {
        public baitap23()
        {
            InitializeComponent();
        }

        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            // Xuất ra mảng
            txtDaySo.Text = string.Empty;
            List<int> list = new List<int>();
            Random rd = new Random();
            int SoLuongMang = int.Parse(txtB.Text) - int.Parse(txtA.Text);
            for(int i = 0;i< SoLuongMang;i++)
            {
            int number = rd.Next(int.Parse(txtA.Text), int.Parse(txtB.Text));
            list.Add(number);
            }
            foreach(int number in list)
            {
                txtDaySo.Text += number + " ";
            }

            //Tính tổng mảng
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            txtTong.Text = sum.ToString();

            //Sắp xếp dãy tăng dần
            list.Sort();
            foreach (int number in list)
            {
                txtSapXep.Text += number + " ";
            }
        }

        private void baitap23_Load(object sender, EventArgs e)
        {
            txtA.Focus();
        }
    }
}
