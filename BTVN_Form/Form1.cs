using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];
                string lastName = lv1.SubItems[0].Text;
                string firstName = lv1.SubItems[1].Text;
                string phone = lv1.SubItems[2].Text;          

                txtLastName.Text = lastName;
                txtFirstName.Text = firstName;
                txtPhone.Text = phone;
            }
        }

       /* private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtLastName.Text);
            lv1.SubItems.Add(txtFirstName.Text);
            lv1.SubItems.Add(txtPhone.Text);

            listView1.Items.Add(lv1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];
                lv1.SubItems[0].Text = txtLastName.Text;
                lv1.SubItems[1].Text = txtFirstName.Text;
                lv1.SubItems[2].Text = txtPhone.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Da xoa thanh cong!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát", "Câu hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
