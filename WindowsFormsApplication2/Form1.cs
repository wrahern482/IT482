using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
            ovalShape1.Visible = false;
            ovalShape2.Visible = false;
            ovalShape3.Visible = false;
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
            MoveCursor();
            generateTestCase();

            
        }
        private void MoveCursor()
        {
            Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width / 2,
                                        Screen.PrimaryScreen.Bounds.Height / 2);
            timer1.Start();
        }​
        private void testGenerator()
        {

         int[] testArray = new int[12];
         


         }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ovalShape1.Visible = false;
        }
        private void ovalShape3_Click(object sender, EventArgs e){
            ovalShape3.Visible = false;
            timer1.Stop();
            //generate_next_test
        }
        private void ovalShape4_Click(object sender, EventArgs e)
        {
            ovalShape4.Visible = false;
            timer1.Stop();
        }
        private void ovalShape5_Click(object sender, EventArgs e)
        {
            ovalShape5.Visible = false;
            timer1.Stop();
        }
        private void ovalShape6_Click(object sender, EventArgs e)
        {
            ovalShape6.Visible = false;
            timer1.Stop();
        }
        private void ovalShape7_Click(object sender, EventArgs e)
        {
            ovalShape7.Visible = false;
            timer1.Stop();
        }
        private void ovalShape8_Click(object sender, EventArgs e)
        {
            ovalShape8.Visible = false;
            timer1.Stop();
        }
        private void ovalShape9_Click(object sender, EventArgs e)
        {
            ovalShape9.Visible = false;
            timer1.Stop();

        }
        private void ovalShape10_Click(object sender, EventArgs e)
        {
            ovalShape10.Visible = false;
            timer1.Stop();
        }
        private void ovalShape11_Click(object sender, EventArgs e)
        {
            ovalShape11.Visible = false;
            timer1.Stop();
        }
        private void ovalShape12_Click(object sender, EventArgs e)
        {
            ovalShape12.Visible = false;
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ListViewItem lv = new ListViewItem(Cursor.Position.X.ToString());
            lv.SubItems.Add(Cursor.Position.Y.ToString());
            
            
        }

        private void generateTestCase(){
             ovalShape1.Visible = true;
            

        }

       }
}

