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
    public partial class baitap28 : Form
    {
        public baitap28()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ns;
            if(txtHT.Text.Trim() == "" || txtMS.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập dầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if(DateTime.TryParse(txtNS.Text.Trim(), out ns))
            {
                FileStream fs = new FileStream("SinhVien.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs);
                fs.Seek(0, SeekOrigin.End);
                streamWriter.WriteLine(txtMS.Text);
                streamWriter.WriteLine(txtHT.Text);
                streamWriter.WriteLine(txtNS.Text);
                streamWriter.Flush();
                fs.Close();
                MessageBox.Show("Lưu thành công","Thông báo",MessageBoxButtons.OK);
            }
            else if(!DateTime.TryParse(txtNS.Text.Trim(), out ns))
            {
                MessageBox.Show("Ngày sinh không hợp lệ !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHienDS_Click(object sender, EventArgs e)
        {  
                FileStream fs = new FileStream("SinhVien.txt", FileMode.Open, FileAccess.Read);
            string[] str = File.ReadAllLines("SinhVien.txt");
            string ds=string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if ((i+1)%3== 0)
                {
                    ds += str[i] + "\r\n";
                }    
                else
                {
                    ds += str[i] + "\t\t\t";
                }
            }
            rtxtDS.Text = ds;
            fs.Close();
          }
    }
}
