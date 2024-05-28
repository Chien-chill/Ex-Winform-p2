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
    public partial class baitap4 : Form
    {
        public baitap4()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyDown += baitap4_KeyDown;
        }

        private void picCD1_Click(object sender, EventArgs e)
        {
            picCD2.Visible = true;
            picCD1.Visible = false;
        }

        private void picCD2_Click(object sender, EventArgs e)
        {
            picCD1.Visible = true;
            picCD2.Visible = false;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
                lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
                lblMessage.ForeColor = Color.Blue;
        }
        private void FontDefault()
        {
            if(!chkItalic.Checked && !chkBold.Checked && !chkUnderline.Checked)
                lblMessage.Font = new Font("Arial", 20, FontStyle.Regular);
        }
        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
                lblMessage.ForeColor = Color.Black;
        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
                lblMessage.Font = new Font("Arial",20,lblMessage.Font.Style^FontStyle.Italic);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
                lblMessage.Font = new Font("Arial", 20, lblMessage.Font.Style^FontStyle.Bold);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
                lblMessage.Font = new Font("Arial", 20, lblMessage.Font.Style^FontStyle.Underline);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + "\n" + txtMessage.Text;
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            lblMessage.Text=string.Empty;
            txtMessage.Text = string.Empty;
            txtName.Text = string.Empty;
            txtName.Focus();
        }
        private void baitap4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDisplay_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void baitap4_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picCD1, "Click me please");
            toolTip1.SetToolTip(picCD2, "Click me please");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
