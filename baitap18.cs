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
    public partial class baitap18 : Form
    {
        public baitap18()
        {
            InitializeComponent();
        }
        public void MessBox_Template(MessageBoxButtons btn,MessageBoxIcon icon)
        {
            MessageBox.Show("Đây là một dạng của Message Box","MessageBox",btn,icon);
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn;
            MessageBoxIcon icon;
            btn = (radbtn1.Checked) ? MessageBoxButtons.OK : (radbtn2.Checked) ? MessageBoxButtons.OKCancel :
                (radbtn3.Checked) ? MessageBoxButtons.AbortRetryIgnore : (radbtn4.Checked) ? MessageBoxButtons.YesNoCancel :
                (radbtn5.Checked) ? MessageBoxButtons.YesNo : (radbtn6.Checked) ? MessageBoxButtons.RetryCancel : (MessageBoxButtons)1;

            icon = (radicon1.Checked) ? MessageBoxIcon.Stop : (radicon2.Checked) ? MessageBoxIcon.Question : (radicon3.Checked) ?
                MessageBoxIcon.Exclamation : (radicon4.Checked) ? MessageBoxIcon.Information : (MessageBoxIcon)1;
            MessBox_Template(btn,icon);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void baitap18_Load(object sender, EventArgs e)
        {

        }

        private void baitap18_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure Exit","Message Box",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }
    }
}
