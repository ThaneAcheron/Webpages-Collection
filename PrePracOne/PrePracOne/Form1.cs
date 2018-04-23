using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections; 
using System.Data.OleDb;

namespace PrePracOne
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //Open the filestream 
            FileStream fs = new FileStream("items.txt", FileMode.Open, FileAccess.Read);
  
            //Apply a buffer 
            BufferedStream buffered = new BufferedStream(fs);
            //Apply to a reader 
            StreamReader reader = new StreamReader(buffered);

            //Reader the reader 
            string line; 
            while((line = reader.ReadLine()) != null)
            {
                checkedListBox1.Items.Add(line);
            }

            reader.Close();
            fs.Close();
            buffered.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true; 

            if(Additemtxtb.Text.Replace(" ", "") != "")
            {
                StreamReader reader = new StreamReader("items.txt");
                string value;
                while ((value = reader.ReadLine()) != null)
                {
                    if (value == Additemtxtb.Text)
                    {
                        valid = false;
                    }
                }

                if(valid == true)
                {

                    reader.Close();
                    //REMEBER THIS!!!!!!!!!!!! NBNBNB
                    StreamWriter witer = new StreamWriter("items.txt",true);

                    witer.WriteLine(Additemtxtb.Text);
                    checkedListBox1.Items.Add(Additemtxtb.Text);
                    witer.Close();
                }
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int current = Int32.Parse(label2.Text);
            current = current + 1;
            label2.Text = current.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
