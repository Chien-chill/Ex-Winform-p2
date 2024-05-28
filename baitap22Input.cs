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
    public partial class baitap22Input : Form
    {
        public baitap22Input()
        {
            InitializeComponent();
        }

        public baitap22 baitap22Reference { get; set; }
        public void btnXacNhan_Click(object sender, EventArgs e)
        {
            baitap22Reference.lstMang.Items.Clear();
            Random rd = new Random();
            for (int i = 0;i<int.Parse(txtInput.Text);i++)
            {
                int number = rd.Next(-100,100);
                baitap22Reference.lstMang.Items.Add(number);
            }    
            this.Close();
        }

        public void baitap22Input_Load(object sender, EventArgs e)
        {

        }
    }
}
