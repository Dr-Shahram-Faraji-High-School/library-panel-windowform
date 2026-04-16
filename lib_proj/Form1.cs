using Microsoft.VisualBasic.Logging;

namespace lib_proj
{
    public partial class Form1 : Form
    {

        byte flag;

        public byte Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        string[] code = new string[100];
        string[] name = new string[100];
        string[] family = new string[100];
        string[] phone = new string[100];
        string[] address = new string[100];
        string[] national = new string[100];
        string[] photo = new string[100];

        string[] bookname = new string[100];
        string[] bookauth = new string[100];
        string[] booktranslator = new string[100];
        string[] bookpublisher = new string[100];
        string[] bookcreated = new string[100];
        string[] booktitle = new string[100];
        string[] bookshabak = new string[100];
        string[] bookphoto = new string[100];

        int book_index = 0;
        int acc_index = 0;

        public void EnableAdmin()
        {
            label8.Text = "مدیر"; label8.ForeColor = System.Drawing.Color.Green;
            tabPage1.Enabled = true;
            tabPage2.Enabled = true;
            Flag = 1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = DateTime.Now.ToString();

            radioButton1.Checked = true;

            textBox10.Enabled = true; // book name
            textBox9.Enabled = false; // auth name
            textBox8.Enabled = false; // title
            textBox7.Enabled = false; // created
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = true; // book name
            textBox9.Enabled = false; // auth name
            textBox8.Enabled = false; // title
            textBox7.Enabled = false; // created
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = false; // book name
            textBox9.Enabled = true; // auth name
            textBox8.Enabled = false; // title
            textBox7.Enabled = false; // created
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = false; // book name
            textBox9.Enabled = false; // auth name
            textBox8.Enabled = true; // title
            textBox7.Enabled = false; // created
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = false; // book name
            textBox9.Enabled = false; // auth name
            textBox8.Enabled = false; // title
            textBox7.Enabled = true; // created
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (Flag == 0 && e.TabPage != tabPage1)
            {
                e.Cancel = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // pic btn
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                photo[acc_index] = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e) // submit btn
        {
            if (textBox1.Text.Trim() == "")
            {
                if (MessageBox.Show("کد عضویت خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox1.Focus();
                }
                return;
            }

            if (textBox2.Text.Trim() == "")
            {
                if (MessageBox.Show("نام خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox2.Focus();
                }
                return;
            }

            if (textBox3.Text.Trim() == "")
            {
                if (MessageBox.Show("نام خانوادگی خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox3.Focus();
                }
                return;
            }

            if (textBox4.Text.Trim() == "")
            {
                if (MessageBox.Show("تلفن خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox4.Focus();
                }
                return;
            }

            if (textBox5.Text.Trim() == "")
            {
                if (MessageBox.Show("نشانی خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox5.Focus();
                }
                return;
            }

            if (textBox6.Text.Trim() == "")
            {
                if (MessageBox.Show("کد ملی خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox6.Focus();
                }
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("لطفا تصویر را انتخاب کنید");
                return;
            }

            code[acc_index] = textBox1.Text;
            name[acc_index] = textBox2.Text;
            family[acc_index] = textBox3.Text;
            phone[acc_index] = textBox4.Text;
            address[acc_index] = textBox5.Text;
            national[acc_index] = textBox6.Text;

            acc_index++;
            Flag = 1;

            MessageBox.Show("ثبت شد");
        }

        private void button1_Click(object sender, EventArgs e) // new btn
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            pictureBox1.Image = null;
        }

        private void button6_Click(object sender, EventArgs e) // book clear btn
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e) // book pic btn
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                bookphoto[acc_index] = ofd.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)// book submit btn
        {
            if (textBox16.Text.Trim() == "")
            {
                if (MessageBox.Show("نام کتاب خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox1.Focus();
                }
                return;
            }

            if (textBox15.Text.Trim() == "")
            {
                if (MessageBox.Show("نام مولف خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox2.Focus();
                }
                return;
            }

            if (textBox14.Text.Trim() == "")
            {
                if (MessageBox.Show("نام مترجم خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox3.Focus();
                }
                return;
            }

            if (textBox13.Text.Trim() == "")
            {
                if (MessageBox.Show("نام انتشارات خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox4.Focus();
                }
                return;
            }

            if (textBox12.Text.Trim() == "")
            {
                if (MessageBox.Show("سال چاپ خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox5.Focus();
                }
                return;
            }

            if (textBox11.Text.Trim() == "")
            {
                if (MessageBox.Show("موضوع خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox6.Focus();
                }
                return;
            }

            if (textBox17.Text.Trim() == "")
            {
                if (MessageBox.Show("شابک خالی است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    textBox6.Focus();
                }
                return;
            }

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("لطفا تصویر کتاب را انتخاب کنید");
                return;
            }

            bookname[book_index] = textBox16.Text;
            bookauth[book_index] = textBox15.Text;
            booktranslator[book_index] = textBox14.Text;
            bookpublisher[book_index] = textBox13.Text;
            bookcreated[book_index] = textBox12.Text;
            booktitle[book_index] = textBox11.Text;
            bookshabak[book_index] = textBox17.Text;


            book_index++;
            Flag = 1;

            MessageBox.Show("ثبت شد");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.ShowDialog();
        }
    }
}