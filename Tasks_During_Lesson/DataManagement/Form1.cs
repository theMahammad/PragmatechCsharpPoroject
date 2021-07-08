using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_add_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            names_lb.Items.Add(tb_add_name.Text.ToLower());
            MessageBox.Show("Əlavə edildi");
            tb_add_name.Text = "";
            tb_add_name.Select();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            
           
            

                if ( names_lb.Items.Contains(tb_search_names.Text.ToLower()) )
                {
                    MessageBox.Show("Sistemdə var");
                }
                else
                {
                MessageBox.Show("Sistemdə yoxdur");
                }
            tb_search_names.Text = "";
            tb_search_names.Select();
            


            }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = names_lb.Items.Count;
            MessageBox.Show($"Toplamda {count} data var");
        }
    }
    }

