// Lab 2
// CIS 199-02
// Due:2/6/2022
// By: R2230

// This program calculates and then displays the dollar amount of a 15%, 18%, and 20% tip,
// according to a given meal price.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // once the button is clicked the code below, 
        // will cause the tip prices to be displayed into each of the corresponding output labels
        private void button1_Click(object sender, EventArgs e)
        {           
            const double TIP_15 = 0.15; // assigns variables and the percentages to their decimal amount
            const double TIP_18 = 0.18;
            const double TIP_20 = 0.20;
            double mealPrice;
            double tip1Price;
            double tip2Price;
            double tip3Price;

            mealPrice = double.Parse(firstNumTxt.Text); // meal price is associated to the number entered in the textbox
         
            tip1Price = mealPrice * TIP_15; // calculates tip prices
            tip2Price = mealPrice * TIP_18;
            tip3Price = mealPrice * TIP_20;

            TIP_15label.Text = tip1Price.ToString("c"); // allows tip prices to be shown in output labels with currency formating
            TIP_18label.Text = tip2Price.ToString("c");
            TIP_20label.Text = tip3Price.ToString("c");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
