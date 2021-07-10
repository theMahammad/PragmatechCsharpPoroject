using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_DataManagement_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {
            if (tb_add_data.Text != "")
            {
               lb_data.Items.Add(tb_add_data.Text.Trim().ToLower());
                tb_add_data.Select();
                tb_add_data.Text = "";

                MessageBox.Show("Əlavə edildi");

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_add_data.Select();
        }
    }
}
