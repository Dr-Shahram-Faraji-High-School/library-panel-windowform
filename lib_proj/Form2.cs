using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lib_proj
{
    public partial class Form2 : Form
    {
        int tryCount = 0;
        private Form1 f1;

        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;
        }

        async void DisableLogin()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;

            MessageBox.Show("بیش از 3 بار اشتباه! 1 دقیقه صبر کنید");

            await Task.Delay(60000);

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;

            tryCount = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox2.Text.Trim();
            string pass = textBox1.Text.Trim();


            if (user == "admin" && pass == "1234")
            {
                f1.EnableAdmin();
                Close();
            }
            else
            {
                tryCount++;

                MessageBox.Show("نام کاربری یا رمز اشتباه است");

                if (tryCount >= 3)
                {
                    DisableLogin();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
