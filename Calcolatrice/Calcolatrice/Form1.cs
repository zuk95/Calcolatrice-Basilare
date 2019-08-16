﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {

        Calcolatrice calcolatrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcolatrice = new Calcolatrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                calcolatrice.Display = Convert.ToDecimal(display.Text);
                display.Text = "";
                calcolatrice.Tastiera("+");
            }
            catch (FormatException f)
            {
                display.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                calcolatrice.Display = Convert.ToDecimal(display.Text);
                calcolatrice.Tastiera("=");
                display.Text = calcolatrice.Result.ToString();
            }
            catch (FormatException f)
            {
                display.Text = "";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcolatrice.Tastiera("C");
            display.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "-";
            }
            else
            {
                
                try
                {
                    calcolatrice.Display = Convert.ToDecimal(display.Text);
                    display.Text = "";
                    calcolatrice.Tastiera("-");
                }
                catch (FormatException f)
                {
                    display.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            try
            {
                calcolatrice.Display = Convert.ToDecimal(display.Text);
                display.Text = "";
                calcolatrice.Tastiera("*");
            }
            catch (FormatException f)
            {
                display.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            try
            {
                calcolatrice.Display = Convert.ToDecimal(display.Text);
                display.Text = "";
                calcolatrice.Tastiera("/");
            }
            catch (FormatException f)
            {
                display.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ",";
        }
    }
}
