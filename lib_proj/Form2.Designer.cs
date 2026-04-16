namespace lib_proj
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(300, 145);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 0;
            button1.Text = "ورود";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 145);
            button2.Name = "button2";
            button2.Size = new Size(142, 34);
            button2.TabIndex = 2;
            button2.Text = "خروج";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 28);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "admin";
            textBox2.Size = new Size(369, 32);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 72);
            label1.Name = "label1";
            label1.Size = new Size(31, 27);
            label1.TabIndex = 5;
            label1.Text = "رمز";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 31);
            label2.Name = "label2";
            label2.Size = new Size(73, 27);
            label2.TabIndex = 6;
            label2.Text = "نام کاربری";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 69);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1234";
            textBox1.Size = new Size(369, 32);
            textBox1.TabIndex = 7;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(372, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 31);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "نمایش رمز";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(584, 193);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}