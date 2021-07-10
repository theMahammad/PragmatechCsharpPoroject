using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5_UserData_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lv_users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_user_data_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.Trim().ToLower();
            string surname = tb_surname.Text.Trim().ToLower();
            string phoneNumber = mtb_phoneNumber.Text;
            string birtday = dtp_birthday.Value.ToString();
            ListViewItem listView = new ListViewItem();
            listView.Text = name;
            listView.SubItems.Add(surname);
            listView.SubItems.Add(phoneNumber);
            listView.SubItems.Add(birtday);
            lv_users.Items.Add(listView);
            MessageBox.Show("Əlavə edildi");
        }
    }
}
