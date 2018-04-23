using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Tickets;
using System.Collections;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets.Class1 GetX; 
            GetX = (Tickets.Class1)Activator.GetObject
                (typeof(Tickets.Class1), "tcp://localhost:8081/Tickets");

           ArrayList list = GetX.GetPrices(); 

            foreach(string value in list)
            {
                Console.WriteLine(value);
                textBox1.Text = textBox1.Text + value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets.Class1 GetX;
            GetX = (Tickets.Class1)Activator.GetObject
                (typeof(Tickets.Class1), "tcp://localhost:8081/Tickets");

            ArrayList list = GetX.GetSinglePrice(textBox2.Text);

            foreach (string value in list)
            { 
                Console.WriteLine(value);
                textBox1.Text = textBox1.Text + value;
            }
        }
    }
}
