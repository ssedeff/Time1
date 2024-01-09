using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gun_ay_hesaplama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac++;
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text=sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            timer1.Stop();
        }
    }
}
