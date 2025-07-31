
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
                label1.Text = "Sonuç: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!\n\nHata: " + ex.Message, "Girdi Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Çýkar
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 - sayi2;
                label1.Text = "Sonuç: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!\n\nHata: " + ex.Message, "Girdi Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Çarp
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 * sayi2;
                label1.Text = "Sonuç: " + sonuc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!\n\nHata: " + ex.Message, "Girdi Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void böl_Click(object sender, EventArgs e) // Böl
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);

                if (sayi2 == 0)
                {
                    MessageBox.Show("Bir sayý 0'a bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double sonuc = sayi1 / sayi2;
                    label1.Text = "Sonuç: " + sonuc.ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!\n\nHata: " + ex.Message, "Girdi Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
