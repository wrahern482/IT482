using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Visible = false;

            
            Circle1();
            
        }
        private void Circle1()
        {
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.Graphics formGraphics = this.CreateGraphics();
        formGraphics.FillEllipse(myBrush, new Rectangle(100,250,30,30));
        myBrush.Dispose();
        formGraphics.Dispose();
        }
}
}
