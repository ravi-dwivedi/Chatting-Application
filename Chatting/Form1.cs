using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Chatting
{
    public partial class Form1 : Form
    {
        Network objNetwork;


        public bool wNetworkPlay = false;

        string wServerIP = "";

        public bool wServer = false;
        public bool wClient = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void list1_Click(object sender, EventArgs e)
        {
            list1.CheckState = CheckState.Checked;
            list2.CheckState = CheckState.Unchecked;
            list2.Enabled = false;
            disconnectToolStripMenuItem.Enabled = true;
            wServer = true;
            objNetwork.StartServer();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list1.Checked||list2.Checked)
            {
                
                list1.CheckState = CheckState.Unchecked;
                list2.CheckState = CheckState.Unchecked;
                list1.Enabled = true;
                list2.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
            }

        }

        private void list2_Click(object sender, EventArgs e)
        {
           /* list2.CheckState = CheckState.Checked;
            list1.CheckState = CheckState.Unchecked;
            list1.Enabled = false;
            disconnectToolStripMenuItem.Enabled = true;
            this.Close();   
            */

            IPHostEntry localHostEntry = Dns.GetHostEntry(Dns.GetHostName());
     //       listBox1.Text = localHostEntry.AddressList[0].ToString();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPHostEntry localHostEntry = Dns.GetHostEntry(Dns.GetHostName());
          //  listBox1.Text = localHostEntry.AddressList[0].ToString();
                //localHostEntry.AddressList[0];

        }

      
    }
}
