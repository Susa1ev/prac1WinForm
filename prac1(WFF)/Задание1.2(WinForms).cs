using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac1_WFF_
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }
        public int a = 0;
        public int b = 0;
        public string chislo = "";
        public char[] bukva;
        private void button1_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBox1.Text, out a) && textBox1.Text.Length == 3)
            {
                chislo = textBox1.Text;
                bukva = chislo.ToCharArray();
                a = Int32.Parse(bukva[0].ToString());
                b = Int32.Parse(bukva[1].ToString());
                if(a>b)
                {
                    label2.Text = "Первая цифра(" + a + ") больше второй(" + b + ")";
                }else if (a<b)
                {
                    label2.Text = "Вторая цифра(" + b+ ") больше первой(" + a + ")";
                }else if(a==b)
                {
                    label2.Text = "Первая цифра(" + a + ") равно второй(" + b + ")";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не трёхзначное число");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
