
using System.Linq.Expressions;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Topla
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 + sayi2;
                label1.Text = "Sonu�: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin!\n\nHata: " + ex.Message, "Girdi Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // ��kar
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 - sayi2;
                label1.Text = "Sonu�: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin!\n\nHata: " + ex.Message, "Girdi Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // �arp
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 * sayi2;
                label1.Text = "Sonu�: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin!\n\nHata: " + ex.Message, "Girdi Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b�l_Click(object sender, EventArgs e) // B�l
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);

                if (sayi2 == 0)
                {
                    MessageBox.Show("Bir say� 0'a b�l�nemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double sonuc = sayi1 / sayi2;
                    label1.Text = "Sonu�: " + sonuc.ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin!\n\nHata: " + ex.Message, "Girdi Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
