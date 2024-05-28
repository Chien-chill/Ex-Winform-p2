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
    public partial class baitap3 : Form
    {
        public baitap3()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += baitap2_KeyDown;
        }
        string Result;
        private void HiddenPic()
        {
            Result=string.Empty;
            picCloudy.Visible = false;
            picRain.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void baitap2_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void radCloudy_CheckedChanged(object sender, EventArgs e)
        {
            HiddenPic();
            if(radCloudy.Checked==true)
            {
                picCloudy.Visible = true;
                Result += "Today is Cloudy";
            }    
        }

        private void radRainy_CheckedChanged(object sender, EventArgs e)
        {
            HiddenPic();
            if (radRainy.Checked==true)
            {
                picRain.Visible = true;
                Result += "Today is Rainy";
            }    
        }

        private void radSnowy_CheckedChanged(object sender, EventArgs e)
        {
            HiddenPic();
            if (radSnowy.Checked==true)
            {
                picSnowy.Visible = true;
                Result += "Today is Snowy";
            }    
        }

        private void radSunny_CheckedChanged(object sender, EventArgs e)
        {
            HiddenPic();
            if (radSunny.Checked==true)
            {
                picSunny.Visible = true;
                Result += "Today is Sunny";
            }    
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Result + ", "+ txtName.Text + " >.< ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baitap2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
