namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show(
           "Введите ФИО",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
                this.Show();
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show(
           "Введите номер телефона",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
                this.Show();
                return;
            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show(
           "Введите Сумму кредита",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
                this.Show();
                return;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show(
           "Выберите тип кредита",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
                this.Show();
                return;
            }
            f2.listBox1.Items.Add(this.textBox1.Text);
            f2.listBox1.Items.Add(this.textBox2.Text);
            f2.listBox1.Items.Add(this.textBox3.Text);
            f2.listBox1.Items.Add(this.comboBox1.Text);
            if (checkBox1.Checked == true)
            {
                f2.label6.Hide();
            }
            if (checkBox1.Checked != true)
            {
                f2.label5.Hide();
            }
            f2.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}