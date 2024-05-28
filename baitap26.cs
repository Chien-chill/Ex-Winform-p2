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
    public partial class baitap26 : Form
    {
        public baitap26()
        {
            InitializeComponent();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin (.txt) |*.txt";
            openFileDialog.ShowDialog();
            if(openFileDialog.ShowDialog () == DialogResult.OK)
            {
                txtLink.Text = openFileDialog.FileName;
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                var str = sr.ReadToEnd();
                rtxtNoidung.Text = str;
                fs.Close();
            }
            
        }
    }
}
