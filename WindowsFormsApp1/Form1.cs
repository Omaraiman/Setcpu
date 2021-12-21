using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double dcpu;
        double dram;
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             dcpu = performanceCPU.NextValue();
             dram = performanceRAM.NextValue();
            progressBar1.Value = (int)dcpu;
            progressBar2.Value = (int)dram;
            label3.Text = String.Format("{00:00.0}%", dcpu);
            label4.Text = String.Format("{00:00.0}%", dram);
            //label3.Text = dcpu.ToString();
            //label4.Text = dram.ToString() ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("wellcome");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            label3.Text = "00 %";
            label4.Text = "00 %";
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            
        }
    }
}
