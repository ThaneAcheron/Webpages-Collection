using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTIQuestionOneB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void FeaturesLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FeaturesLstBox.SelectedIndex == 0)
            {

                control1.SetValues = 0;               
              
            }
            if(FeaturesLstBox.SelectedIndex == 1)
            {
                control1.SetValues = 1;
                
            }

         
        }

        private void control1_Load(object sender, EventArgs e)
        {

        }
    }
}
