using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace random
{  
  public partial class Form1 : Form

    {   Random arithmos = new Random();
        int tuxaios;
       
        private void label2_Click(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();

             timer1.Interval = 750;
             timer1.Start();           
              }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }                   
        private void timer1_Tick(object sender, EventArgs e)
        {            
            tuxaios = arithmos.Next(1,50);
            label1.Text = tuxaios.ToString();
            tuxaios = arithmos.Next(1, 50);
            label2.Text = tuxaios.ToString();
            tuxaios = arithmos.Next(1, 50);
            label3.Text = tuxaios.ToString();
            tuxaios = arithmos.Next(1, 50);
            label4.Text = tuxaios.ToString();
            tuxaios = arithmos.Next(1, 50);
            label5.Text = tuxaios.ToString();                                                                     
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();           
            label6.Text = (Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) +
            Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text)).ToString();           

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
