using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace GraphicTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(300,200))
            {
                
                    pictureBox1.Image = Draw2();
                    pictureBox1.Refresh();

                
            }
        }
        private Bitmap Draw2()
        {
            Bitmap bitmap = new Bitmap(300, 200);
            
                Graphics graphics = Graphics.FromImage(bitmap);
               
                    //draw image..
                    var p1 = new Point(0, 0);
                    var p2 = new Point(150, 250);
                    var pen = new Pen(Color.Black, 3);



                    graphics.DrawLine(pen, p1, p2);
               
                return bitmap;
            
        }
    }
}
