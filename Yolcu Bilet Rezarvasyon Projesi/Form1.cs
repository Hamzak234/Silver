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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad;
            int parola;
            adsoyad = Convert.ToString(textBox1.Text);
            parola = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "Hamza Kaplan" && textBox2.Text == "1234")
            {
                label3.Text = "Kulanıcı adı doğru girilmiştir";
            }
            else
            {
                label3.Text = "kulancı adı veya parola yanlış";
            }
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();

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
