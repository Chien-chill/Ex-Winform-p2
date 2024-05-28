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
    public partial class baitap11 : Form
    {
        public baitap11()
        {
            InitializeComponent();
        }
        public  void pushUpTxt(Button btn)
        {
         txtKQ.Text += btn.Text;        
        }
        double a;
        string s;
        public void Temp()
        {
            a = double.Parse(txtKQ.Text);
            txtKQ.Clear();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn3);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn4);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn6);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn8);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn9);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pushUpTxt(btn0);

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Temp();
            s = "+";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            switch(s)
            {
                case "+": a += double.Parse(txtKQ.Text);
                    break;
                case "-":
                    a -= double.Parse(txtKQ.Text);
                    break;
                case "*":
                    a *= double.Parse(txtKQ.Text);
                    break;
                case "/":
                    a /= double.Parse(txtKQ.Text);
                    break;
            }
            txtKQ.Text = a.ToString();
        }
        
        private void btnTru_Click(object sender, EventArgs e)
        {
            Temp();
            s = "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Temp();
            s = "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Temp();
            s = "/";
        }

        private void btnPhay_Click(object sender, EventArgs e)
        {
            if(txtKQ.Text!="")
            pushUpTxt(btnPhay);
            else
            {
                txtKQ.Text = "0.";
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Text=string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baitap11_Load(object sender, EventArgs e)
        {

        }
    }
}
