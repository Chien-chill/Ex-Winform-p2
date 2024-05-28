using DevExpress.Utils.CommonDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_lab2
{
    public partial class baitap27 : Form
    {
        public baitap27()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tập tin (.txt)|*.txt";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK )
            {
                lstTapTin.Items.Add(ofd.FileName);
            }    
        }

        private void lstTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLink.Text = lstTapTin.SelectedItem.ToString();
            if(lstTapTin.SelectedItem!=null)
            {
            FileStream fs = new FileStream(lstTapTin.SelectedItem.ToString(),FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            var str = sr.ReadToEnd();
            fs.Close();
            rtxtNoiDung.Text = str;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstTapTin.Items.RemoveAt(lstTapTin.SelectedIndices[0]);
        }
    }
}
