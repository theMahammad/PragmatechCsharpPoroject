using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Task_3_DataManagementMoreDeveloped_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void btn_randomize_datas_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ListBox copy_items = new ListBox();
            
            
            for (int i = 0; i<lb_data.Items.Count; i++)
            {   
                int limit = lb_data.Items.Count;
                int random_index = random.Next(0, limit);
                while (copy_items.Items.Contains(lb_data.Items[random_index])) {
                    random_index= random.Next(0, limit);
                }
                copy_items.Items.Add(lb_data.Items[random_index]);
              


                
            }
            for(int j=0;j<lb_data.Items.Count ; j++)
            {
                lb_data.Items[j] = copy_items.Items[j];

            }
            MessageBox.Show("Qarışdırıldı");
        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {
            lb_data.Items.Add(tb_add_data.Text.ToLower());
            MessageBox.Show("Əlavə edildi");
            tb_add_data.Text = "";
            tb_add_data.Select();
        }

        private void btn_delete_data_Click(object sender, EventArgs e)
        {
            if (lb_data.Items.Contains(tb_delete_data.Text.ToLower()))
            {
                lb_data.Items.Remove(tb_delete_data.Text.ToLower());
                MessageBox.Show("Silindi");
                tb_delete_data.Text = "";
                tb_delete_data.Select();
            }
            else
            {
                MessageBox.Show("Sistemdə belə data yoxdur");
            }
            
           
        }

        private void lb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_delete_selected.Show();
        }

        private void lb_data_Leave(object sender, EventArgs e)
        {
            
            lb_data.ClearSelected();
            btn_delete_selected.Visible=false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_delete_selected.Hide();
        }

        private void btn_delete_selected_Click(object sender, EventArgs e)
        {
            lb_data.Items.RemoveAt(lb_data.SelectedIndex);
            MessageBox.Show("Seçilmiş data silindi");
        }
    }
}
