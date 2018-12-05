using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ccalculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        String operatorperform = "";
        bool isoperationperform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoperationperform))
             textBox1.Clear(); 
                 isoperationperform = false;

                Button button = (Button)sender;

                textBox1.Text = textBox1.Text + button.Text;
               
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorperform = button.Text;
            resultvalue = Double.Parse(textBox1.Text);
            labeloperationcurrentoperation.Text = resultvalue + " " + operatorperform;
            isoperationperform = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operatorperform)
            {
                case "+":
                    textBox1.Text =(resultvalue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text =(resultvalue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text =(resultvalue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text =(resultvalue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
