using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections; 

namespace CTIQuestionOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form onload  
            //Set the values for the checkboxlist 
            //Start an instance 
            StreamReader Reader = new StreamReader("Features.txt");

            //Read 
            string featuredValue = Reader.ReadLine();

            //Set the values on the checkboxlist 
            while (featuredValue != null)
            {
                FeaturesTxtbL.Items.Add(featuredValue);
                featuredValue = Reader.ReadLine();
            }
            //Close the Reader 
            Reader.Close();
        }

        private void AddFeatureBtn_Click(object sender, EventArgs e)
        {
            //This variable is used to indicated weather the textbox contains a valid value 
            bool IsValidFeature;

            //Start an instance of the reader 
            StreamReader Reader = new StreamReader("Features.txt");

            //Read from the txt file
            string featuredValue = Reader.ReadLine();
            //Set default value
            IsValidFeature = true;

            //Validate the input 
            if (FeatureTxtb.Text.Replace(" ", "") != "")
            {
                while (featuredValue != null)
                {
                    if (featuredValue == FeatureTxtb.Text)
                    {
                        IsValidFeature = false;
                        break;
                    }
                    featuredValue = Reader.ReadLine();
                }
            }
            else
            {
                IsValidFeature = false;
            }

            //Close the reader 
            Reader.Close();
            Reader.Dispose();

            //Set the values accordingly 
            if (IsValidFeature == true)
            {
                StreamWriter Writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Features.txt", true);
                Writer.WriteLine(FeatureTxtb.Text.ToString());
                FeaturesTxtbL.Items.Add(FeatureTxtb.Text);
                Writer.Close();

                MessageLble.Text = "Sucessful";
            }
            else
            {
                MessageLble.Text = "Invalid";
            }


        }

        private void WriteInfoBtn_Click(object sender, EventArgs e)
        {
            if (FileNameTxtb.Text.Replace(" ", "") != "")
            {
                FileStream fs = File.Create(FileNameTxtb.Text.ToString() + ".txt");
                fs.Close();
               // MessageLble.Text = "Created!";

                ArrayList SelectedValues  = new ArrayList(FeaturesTxtbL.SelectedItems);
                StreamWriter write = new StreamWriter(FileNameTxtb.Text.ToString() + ".txt");
                
                foreach(string value in FeaturesTxtbL.CheckedItems)
                {
                    write.WriteLine(value); 
                }

                write.Close();
                MessageLble.Text = "Writen to file!";
            }
            else
            {
                MessageLble.Text = "Please enter a value!";
            }
        }
    }
}

