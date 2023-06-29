using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox3.Text = "login";
            }
            else if (IsValidEmail(email))
            {
                textBox3.Text = email;
                textBox3.Text = textBox1.Text;
            }
            else
            {
                textBox3.Text = "Invalid email";
            }


            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox4.Text = "password";
            }
            else
            {
                textBox4.Text = textBox2.Text;
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "asd" && textBox1.Text == "qwe@email.com")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else 
            {
                textBox4.Text = "Неверный пароль или почта";
            }
        }
    }
}
