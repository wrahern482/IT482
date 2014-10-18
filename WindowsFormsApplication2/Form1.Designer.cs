using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication2
    
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape8 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape9 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape10 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape11 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape12 = new Microsoft.VisualBasic.PowerPacks.OvalShape();

            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "   This test will require you to click the circles as quickly as possible.       " +
    "       \r\n                                         Good Luck! ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape5,
            this.ovalShape6,
            this.ovalShape7,
            this.ovalShape8,
            this.ovalShape9,
            this.ovalShape10,
            this.ovalShape11,
            this.ovalShape12,
            this.ovalShape4,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(440, 284);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
           

            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = Color.Red;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.Location = new System.Drawing.Point(283, Screen.PrimaryScreen.Bounds.Height / 2 - 75);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(150, 150);
            this.ovalShape1.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BackColor = Color.Red;
            this.ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape2.Location = new System.Drawing.Point(24, Screen.PrimaryScreen.Bounds.Height / 2 - 25);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(50, 50);
            this.ovalShape2.Click += new System.EventHandler(this.ovalShape2_Click);
            // 
            // ovalShape3
            // 
            this.ovalShape3.BackColor = Color.Red;
            this.ovalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape3.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - 100, Screen.PrimaryScreen.Bounds.Height / 2 - 50);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(100, 100);
            this.ovalShape3.Click += new System.EventHandler(this.ovalShape3_Click);
            ///EDIT HERE
            // 
            // ovalShape4
            // 
            this.ovalShape4.BackColor = Color.Red;
            this.ovalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape4.Location = new System.Drawing.Point(283, Screen.PrimaryScreen.Bounds.Height / 2 - 75);
            this.ovalShape4.Name = "ovalShape4";
            this.ovalShape4.Size = new System.Drawing.Size(150, 150);
            this.ovalShape4.Click += new System.EventHandler(this.ovalShape4_Click);
            // 
            // ovalShape5
            // 
            this.ovalShape5.BackColor = Color.Red;
            this.ovalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape5.Location = new System.Drawing.Point(24, Screen.PrimaryScreen.Bounds.Height / 2 - 25);
            this.ovalShape5.Name = "ovalShape5";
            this.ovalShape5.Size = new System.Drawing.Size(50, 50);
            this.ovalShape5.Click += new System.EventHandler(this.ovalShape5_Click);
            // 
            // ovalShape6
            // 
            this.ovalShape6.BackColor = Color.Red;
            this.ovalShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape6.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - 100, Screen.PrimaryScreen.Bounds.Height / 2 - 50);
            this.ovalShape6.Name = "ovalShape6";
            this.ovalShape6.Size = new System.Drawing.Size(100, 100);
            this.ovalShape6.Click += new System.EventHandler(this.ovalShape6_Click);
            //Edit2 
            //
            // ovalShape7
            // 
            this.ovalShape7.BackColor = Color.Red;
            this.ovalShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape7.Location = new System.Drawing.Point(283, Screen.PrimaryScreen.Bounds.Height / 2 - 75);
            this.ovalShape7.Name = "ovalShape7";
            this.ovalShape7.Size = new System.Drawing.Size(150, 150);
            this.ovalShape7.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // ovalShape8
            // 
            this.ovalShape8.BackColor = Color.Red;
            this.ovalShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape8.Location = new System.Drawing.Point(24, Screen.PrimaryScreen.Bounds.Height / 2 - 25);
            this.ovalShape8.Name = "ovalShape8";
            this.ovalShape8.Size = new System.Drawing.Size(50, 50);
            this.ovalShape8.Click += new System.EventHandler(this.ovalShape2_Click);
            // 
            // ovalShape9
            // 
            this.ovalShape9.BackColor = Color.Red;
            this.ovalShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape9.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - 100, Screen.PrimaryScreen.Bounds.Height / 2 - 50);
            this.ovalShape9.Name = "ovalShape9";
            this.ovalShape9.Size = new System.Drawing.Size(100, 100);
            this.ovalShape9.Click += new System.EventHandler(this.ovalShape9_Click);
            ///
            // 
            // ovalShape10
            // 
            this.ovalShape10.BackColor = Color.Red;
            this.ovalShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape10.Location = new System.Drawing.Point(283, Screen.PrimaryScreen.Bounds.Height / 2 - 75);
            this.ovalShape10.Name = "ovalShape10";
            this.ovalShape10.Size = new System.Drawing.Size(150, 150);
            this.ovalShape10.Click += new System.EventHandler(this.ovalShape10_Click);
            // 
            // ovalShape11
            // 
            this.ovalShape11.BackColor = Color.Red;
            this.ovalShape11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape11.Location = new System.Drawing.Point(24, Screen.PrimaryScreen.Bounds.Height / 2 - 25);
            this.ovalShape11.Name = "ovalShape11";
            this.ovalShape11.Size = new System.Drawing.Size(50, 50);
            this.ovalShape11.Click += new System.EventHandler(this.ovalShape11_Click);
            // 
            // ovalShape12
            // 
            this.ovalShape12.BackColor = Color.Red;
            this.ovalShape12.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape12.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - 100, Screen.PrimaryScreen.Bounds.Height / 2 - 50);
            this.ovalShape12.Name = "ovalShape12";
            this.ovalShape12.Size = new System.Drawing.Size(100, 100);
            this.ovalShape12.Click += new System.EventHandler(this.ovalShape12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           // this.BackColor = System.Drawing.SystemColors.
            this.ClientSize = new System.Drawing.Size(440, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Red Team Experiment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape7;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape8;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape9;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape10;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape11;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape12;
        private System.Windows.Forms.Timer timer1;

    }
}

