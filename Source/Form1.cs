using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AddTOCombo2("Computer Science", "English", "Microbiology");

        }
        void AddTOCombo2(string x1, string x2, string x3)
        {
            comboBox2.Items.Add(x1);
            comboBox2.Items.Add(x2);
            comboBox2.Items.Add(x3);
        }
        void AddTOCombo1(string x1 = "", string x2 = "", string x3 = "")
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(x1);
            comboBox1.Items.Add(x2);
            comboBox1.Items.Add(x3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("FirstName: " + textBox1.Text);
            listBox1.Items.Add("LastName: " + textBox2.Text);
            


            //First Way 
            listBox1.Items.Add("Department: " + comboBox2.Text);

            //Second Way
            listBox1.Items.Add("Subject: " + comboBox1.Items[comboBox1.SelectedIndex]);

            //Therid way 
            //listBox1.Items.Add("Subject: " + comboBox1.SelectedItem);


            listBox1.Items.Add("Grade: " + textBox5.Text);
            listBox1.Items.Add("____________________________________");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "English":
                    AddTOCombo1("English", "Acadmic Writeing", "Acadimic Debate");
                    break;
                case "Computer Science":
                    AddTOCombo1("English", "Acadmic Computing", "Computer Organzion");
                    break;
                case "Microbiology":
                    AddTOCombo1("English", "Gernal Chimstry", "Nutrion");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ALL = "";
            string filename = textBox4.Text;
            string filepath = textBox3.Text;
            string fullpath = filepath + "\\" + filename + ".txt";
            foreach (string x in listBox1.Items)
            { ALL = ALL + x + "\n"; }
            try
            { File.WriteAllText(fullpath, ALL); }
            catch { MessageBox.Show("Invaild File Path"); }

        }


    }
}
