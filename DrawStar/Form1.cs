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

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                    

            

        }
        Pen pen = new Pen(Color.Black, 1);
        Graphics gpix;//graphics definition
        //the method to draw stars
        void DrawStar(Pen pen, float x, float y, float size)
        {
            gpix = this.CreateGraphics();

            float scale = size / 220;

            //defines x and y values (points in star)
            int x1 = 0;
            int x2 = 75;
            int x3 = 100;
            int x4 = 125;
            int x5 = 200;
            int x6 = 140;
            int x7= 165;
            int x8 = 100;
            int x9 = 35;
            int x10 = 60;

            int y1 = 80;
            int y2 = 80;
            int y3 = 0;
            int y4 = 80;
            int y5 = 80;
            int y6 = 120;
            int y7 = 200;
            int y8 = 150;
            int y9 = 200;
            int y10 = 120;

            //draws the star
            gpix.DrawLine(pen, x1 * scale + x, y1 * scale + y, x2 * scale + x, y2 * scale + y);
            gpix.DrawLine(pen, x2 * scale + x, y2 * scale + y, x3 * scale + x, y3 * scale + y);
            gpix.DrawLine(pen, x3 * scale + x, y3 * scale + y, x4 * scale + x, y4 * scale + y);
            gpix.DrawLine(pen, x4 * scale + x, y4 * scale + y, x5 * scale + x, y5 * scale + y);
            gpix.DrawLine(pen, x5 * scale + x, y5 * scale + y, x6 * scale + x, y6 * scale + y);
            gpix.DrawLine(pen, x6 * scale + x, y6 * scale + y, x7 * scale + x, y7 * scale + y);
            gpix.DrawLine(pen, x7 * scale + x, y7 * scale + y, x8 * scale + x, y8 * scale + y);
            gpix.DrawLine(pen, x8 * scale + x, y8 * scale + y, x9 * scale + x, y9 * scale + y);
            gpix.DrawLine(pen, x9 * scale + x, y9 * scale + y, x10 * scale + x, y10 * scale + y);
            gpix.DrawLine(pen, x10 * scale + x, y10 * scale + y, x1 * scale + x, y1 * scale + y);
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
