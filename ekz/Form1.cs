using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();

            if (webBrowser1 != null)
            {

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                name = openFileDialog1.FileName;
                webBrowser1.Navigate(name);
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 1 задание
        {
            int a = 0;
            double x = 3, y = 3;
            
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            double skv = x * x;
            double skr = (x * x) + (y * y);

            if ((skr < 9) || ((x <= 0) && (x != -3) && (y >= 0) && (y != 3)))
            { a = 1; };

            if ((skv <9) && (skr>9) && (a != 1))
            {
                toolStripStatusLabel1.Text = "Точка входит";
            }
            else if ((skr==9) || (skv == 9) && (a!=1))
            {
                toolStripStatusLabel1.Text = "Точка на границе";
            }
            else if ((a == 1) || ( (skr<9) || ((skr>9) && (skv >9))))
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double x = 0, y = 0;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            
            if ((x > -6) && (x < 7) && (y > 1) && (y < 6))
            {
                toolStripStatusLabel1.Text = "Точка входит";
            }
            else if ((((x >= -6) || (x <= 7)) && (y == 1)) || ((y == 6) && ((x >= -3) && (x<=4))))
            {
                toolStripStatusLabel1.Text = "Точка на границе";
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }
    }
}
