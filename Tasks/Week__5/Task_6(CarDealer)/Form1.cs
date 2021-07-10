using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_CarDealer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = cb_brand.SelectedItem.ToString();
            string[] bmw = { "X5", "X6" };
            string[] mercedes = { "Yeşka", "Çeşka" };
            string[] lada = { "2106","2107" };
            switch (selectedBrand)
            {
                case "BMW":
                    cb_model.Items.Clear();
                    cb_model.Items.AddRange(bmw);
                    cb_model.SelectedItem = bmw[0];
                    break;
                case "Mercedes":
                    cb_model.Items.Clear();
                    cb_model.Items.AddRange(mercedes);
                    cb_model.SelectedItem = mercedes[0];
                    break;
                case "Lada":
                    cb_model.Items.Clear();
                    cb_model.Items.AddRange(lada);
                    cb_model.SelectedItem = lada[0];
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_fuelType.SelectedIndex = 0;
            cb_gearType.SelectedIndex = 0;
            cb_kuza.SelectedIndex = 0;
            cb_motorType.SelectedIndex = 0;
            cb_brand.SelectedIndex = 0; 
        }

        private void btn_add_order_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = cb_brand.SelectedItem.ToString();
            listViewItem.SubItems.Add(cb_model.Text);
            listViewItem.SubItems.Add(cb_fuelType.Text);
            listViewItem.SubItems.Add(cb_kuza.Text);
            listViewItem.SubItems.Add(cb_gearType.Text);
            listViewItem.SubItems.Add(cb_motorType.Text);
            listViewItem.SubItems.Add(dateTimePicker1.Text);
            listViewItem.UseItemStyleForSubItems = false;
            listViewItem.SubItems.Add("").BackColor=colorDialog1.Color;
            lv_orders.Items.Add(listViewItem);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
