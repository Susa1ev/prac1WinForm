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
    public partial class MainForm : Form
    {
        public double Area = 0.0;
        public double Pi = Math.PI;
        public double Radius = 0.0;

        public MainForm()
        {
            InitializeComponent();            
            label1.Text = "Введите площадь";
            label2.Text = "Результат";
            ShowCircle();
        }

        private string ShowCircle()
        {
            return "R = (" + Area + "/Пи)^(1/2) = " + Radius;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(textBox1.Text, out Area))
            {
                Radius = Math.Sqrt(Area / Pi);
                label2.Text = ShowCircle();
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm2 mainForm2 = new MainForm2();
            mainForm2.Show();
        }
    }
}
