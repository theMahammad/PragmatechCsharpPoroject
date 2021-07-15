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

namespace Task_1_ShoppingManagement_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string[] laptops = { "HP Pavilion 150", "Dell Inspiron", "Lenovo Thinkpad" };
        string[] headphones = { "Airpods", "Airpod Pro", "Redmi Airdots", "I11" };
        string[] smartWatches = { "Mi Band 4", "Mi Band 5", "Smart Watch E50" };
        ArrayList copy = new ArrayList();
        public void fillProductsByCategory()
        {
            string category_name = cb_category.Text;
            cb_products.Items.Clear();
            switch (category_name)
            {
                case "Noutbuklar":
                   
                    cb_products.Items.AddRange(laptops);
                    break;
                case "Nauşniklər":
                    
                    cb_products.Items.AddRange(headphones);
                    break;
                case "Ağıllı Saatlar":
                  
                    cb_products.Items.AddRange(smartWatches);
                    break;
                default:
                    break;


            }
            cb_products.SelectedIndex = 0;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            cb_category.SelectedIndex = 0;
            cb_delivery_type.SelectedIndex = 0;
            fillProductsByCategory();
          
          

        }
        

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillProductsByCategory();
        }

        private void btn_give_order_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.category = cb_category.Text;
            order.date = dateTimePicker1.Value;
            order.delivery_type = cb_delivery_type.Text;
            order.price = nup_price.Value;
            order.product = cb_products.Text;
            order.weight = (double)nup_weight.Value;
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = order.category;
            listViewItem.SubItems.Add(order.product);
            listViewItem.SubItems.Add(order.delivery_type);
            listViewItem.SubItems.Add(order.date.ToString());
            listViewItem.SubItems.Add(order.price.ToString());
            listViewItem.SubItems.Add(order.weight.ToString());
           
           
            
            lv_orders.Items.Add(listViewItem);
            MessageBox.Show("Əlavə edildi");

            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchedText = tb_search.Text;
            ArrayList temp_list = new ArrayList();
            int count = 0;
            
            
            foreach(ListViewItem item in lv_orders.Items)
            {
                foreach(ListViewItem.ListViewSubItem subitem in item.SubItems)
                {

                    if (subitem.Text == searchedText)
                    {
                        lv_orders.Items.Remove(item);
                        temp_list.Add(item);
                        count++;
                        MessageBox.Show("Tapıldı");
                    }
                    
                    
                }
            }


            if (count > 0)
            {
                lv_orders.Items.Clear();
               
            }
           foreach(ListViewItem item in temp_list)
            {
                lv_orders.Items.Add(item);
            }
          
            
            
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lv_orders_ItemActivate(object sender, EventArgs e)
        {

        }

        private void btn_remove_selected_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem selected_item in lv_orders.SelectedItems)
            {
                lv_orders.Items.Remove(selected_item);
            }
            
        }
    }
}
