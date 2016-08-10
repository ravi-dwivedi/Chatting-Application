using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Form2 : Form
    {
        public String Ip;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = "Enter the Ip address of the person you want to connect ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Ip = textBox1.Text;
                this.Close();
            }
            else
            {
                label2.Text = "First enter a Valid Ip";
            }
        }

      
    }
}
