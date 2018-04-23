using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 

namespace CTIQuestionOneB
{
    public partial class Control : UserControl
    {
        private int selected;
        public int selectedval
        {
            get
            {
                return selectedval;
            }
            set
            {
               // selectedval = value;
                SelectedFeaturedLble.Text = "!";
            }
        }

        public Control()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        public int SetValues
        {

            set
            {
                selected = value;

                if (selected == 0)
                {
                    StreamReader Read = new StreamReader("AirCon.txt");
                    DescriptionTxtb.Text = Read.ReadToEnd();

                    PictureBx.ImageLocation = "AirCon.png"; 
                    SelectedFeaturedLble.Text = "AirCon.txt";
                }
                if (selected == 1)
                {
                    StreamReader Read = new StreamReader("powersteering.txt");
                    DescriptionTxtb.Text = Read.ReadToEnd();

                    PictureBx.ImageLocation = "PowerSteering.png";
                    SelectedFeaturedLble.Text = "Power steering";
                }

            }
            get
            {
                return selected;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedFeaturedLble.Text = "Power steering";
        }
    }
}
