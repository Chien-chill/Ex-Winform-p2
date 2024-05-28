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
using System.Xml.Linq;

namespace baitap_lab2
{
    public partial class baitap29 : Form
    {
        public baitap29()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ns;
            if (txtHT.Text.Trim() == "" || txtMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập dầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (DateTime.TryParse(txtNS.Text.Trim(), out ns))
            {
                ListViewItem item = new ListViewItem(txtMS.Text);
                item.SubItems.Add(txtHT.Text);
                item.SubItems.Add(txtNS.Text);
                lstvDS.Items.Add(item);
            }
            else if (!DateTime.TryParse(txtNS.Text.Trim(), out ns))
            {
                MessageBox.Show("Ngày sinh không hợp lệ !", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("SinhVien.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);
            fs.Seek(0, SeekOrigin.End);
            foreach(ListViewItem item in lstvDS.Items)
            {
            streamWriter.WriteLine(item.SubItems[0].Text);
            streamWriter.WriteLine(item.SubItems[1].Text);
            streamWriter.WriteLine(item.SubItems[2].Text);
            }
            streamWriter.Flush();
            fs.Close();
            MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstvDS.SelectedItems.Count > 0)
            {
                lstvDS.Items.RemoveAt(lstvDS.SelectedIndices[0]);
            }
        }

        private void baitap29_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("SinhVien.txt", FileMode.Open, FileAccess.Read);
            string[] str = File.ReadAllLines("SinhVien.txt");
            for (int i = 0; i < str.Length; i++)
            {
                    ListViewItem item = new ListViewItem(str[i]);
                    i+=1;
                    item.SubItems.Add(str[i]);
                    i+=1;
                    item.SubItems.Add(str[i]);
                    lstvDS.Items.Add(item);
            }
            fs.Close();
        }
    }
    }
