using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace threadanaliticForms
{
    public partial class Form1 : Form
    {
        Thread th1;
        Thread th2;

        Random rnd;

        public Form1()
        {
            InitializeComponent();
        }

        public void threadRed()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.OrangeRed, 4), new Rectangle(rnd.Next(0,this.Width), rnd.Next(0, this.Height),20,20));
                Thread.Sleep(100);
            }
            MessageBox.Show(" Red Marker complete ");
        }

        public void threadBlue()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.CadetBlue, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show(" Blue Marker complete ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadRed);
            th1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadBlue);
            th2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }
    }
}
