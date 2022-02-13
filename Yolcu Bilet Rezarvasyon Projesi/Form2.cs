using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("yolcunun koltuk numarası 1 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox6.Items.Add("yolcunun koltuk numarası 2 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox6.Items.Add("yolcunun koltuk numarası 3 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox6.Items.Add("yolcunun koltuk numarası 4 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox6.Items.Add("yolcunun koltuk numarası 5 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            listBox6.Items.Add("yolcunun koltuk numarası 6 ");
            listBox2.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add("Erkek");
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add("Kadın");
            }
            button6.Enabled = false;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
 
}
    
