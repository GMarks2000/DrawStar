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
            SplashScreen();//calls the splashscreen method                       
        }
        Pen pen = new Pen(Color.Black, 1);
        Graphics gpix;//graphics definition

        //my personal splashscreen method
        public void SplashScreen()
        {   
            //makes form invisible
            Form ss = new Form();
            ss.FormBorderStyle = FormBorderStyle.None;
            ss.Size = new Size(400, 400);
            ss.StartPosition = FormStartPosition.CenterScreen;
            ss.BackColor = Color.Red;
            ss.TransparencyKey = Color.Red;

            ss.Show();

            Graphics ssGraphics = ss.CreateGraphics();
            SolidBrush ssBrush = new SolidBrush(Color.DarkBlue);
            Font ssFont = new Font("Liberation Mono", 30, FontStyle.Bold);  //font for my name
            Font subtitles = new Font("Liberation Mono", 20);               //font for subtitles.
            ssGraphics.FillEllipse(ssBrush, 0, 0, 400, 400);

            Thread.Sleep(2000);

            //causes the "a" to descend
            for (int i = -50; i < 50; i += 2)
            {
                ssBrush.Color = Color.DarkBlue;
                ssGraphics.FillEllipse(ssBrush, 0, 0, 400, 400);

                ssBrush.Color = Color.Blue;
                ssGraphics.FillEllipse(ssBrush, 180, i, 50, 50);

                ssBrush.Color = Color.LightCyan;
                ssGraphics.DrawString("A", subtitles, ssBrush, 190, i + 10);
                Thread.Sleep(5);

            }

            ssBrush.Color = Color.White;

            //causes my name to rotate in
            for (int i = 90; i > 0; i--)
            {

                ssBrush.Color = Color.DarkBlue;
                ssGraphics.FillEllipse(ssBrush, 0, 0, 400, 400);

                ssBrush.Color = Color.Blue;
                ssGraphics.FillEllipse(ssBrush, 180, 50, 50, 50);

                ssBrush.Color = Color.LightCyan;
                ssGraphics.DrawString("A", subtitles, ssBrush, 190, 60);

                ssBrush.Color = Color.White;
                ssGraphics.TranslateTransform(200, 50);
                ssGraphics.RotateTransform(i);//rotates canvas before drawing name
                ssGraphics.DrawString("Gareth Marks", ssFont, ssBrush, -150, 100); //draws my name
                ssGraphics.ResetTransform();//resets rotation

                Thread.Sleep(5);
            }

            string[] letters = { "p", "r", "o", "d", "u", "c", "t", "i", "o", "n", "s", }; //array to hold letters

            ssBrush.Color = Color.Cyan;

            for (int i = 0; i < 10; i++)
            {
                ssGraphics.DrawString(letters[i], subtitles, ssBrush, i * 18 + 70, 200);//causes productions to appear one letter at a time
                Thread.Sleep(200);
            }


            for (int i = 50; i < 200; i++)
            {
                ssGraphics.FillRectangle(ssBrush, i, 330, 3, 3);
                ssGraphics.FillRectangle(ssBrush, 400 - i, 330, 3, 3);//causes "loading bars" to fill in at the end
                Thread.Sleep(10);
            }
            Thread.Sleep(3000);
        }
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

            //draws the star by multiplying each x and y by scale and adding the user-supplied x and y values
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
    }
}
