using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int getResult()
        {
            char operation = Convert.ToChar(cb_operation.Text);

           
            int result=0;
            switch (operation)
            {
                case '+':
                    result = (int)( nup_firstNumber.Value + nup_secondNumber.Value);
                    break;
                case '-':
                    result =(int) (nup_firstNumber.Value - nup_secondNumber.Value);
                    break;
                case '*':
                    result = (int)(nup_firstNumber.Value * nup_secondNumber.Value);
                    break;
                case '/':
                    if (nup_secondNumber.Value != 0)
                    {
                        result = (int)(nup_firstNumber.Value / nup_secondNumber.Value);
                    }
                    else
                    {
                        MessageBox.Show("Ədəd 0-a bölünə bilməz");
                    }
                    
                    break;
                case '%':
                    result = (int) (nup_firstNumber.Value % nup_secondNumber.Value);
                    break;
                default:
                    result = 0;
                    break;
                   

            }
            return result;
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbl_result.Text = getResult().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_result.Text = getResult().ToString();
        }

        private void nup_secondNumber_ValueChanged(object sender, EventArgs e)
        {
            lbl_result.Text = getResult().ToString();
        }

        private void nup_secondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_result.Text = getResult().ToString();
        }

        private void nup_firstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lbl_result.Text = getResult().ToString();
        }

        private void nup_firstNumber_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_result.Text = getResult().ToString();
        }
    }
}
