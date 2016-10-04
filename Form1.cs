using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Black, 1);
            Pen myPenYellow = new Pen(System.Drawing.Color.Yellow, 2);
            Pen myPenGray = new Pen(System.Drawing.Color.LightGray, 1);
            Pen myPenDarkGray = new Pen(System.Drawing.Color.DarkGray, 1);
            Pen myPenBlue = new Pen(System.Drawing.Color.Blue);
            Pen myPenWhite = new Pen(System.Drawing.Color.White);

            Brush myBrush = new SolidBrush(Color.LightGray);
            Brush myBrushYellow = new SolidBrush(Color.Yellow);
            Brush myBrushBlue = new SolidBrush(Color.LightSteelBlue);
            Brush myBrushWhite = new SolidBrush(Color.White);
            Brush myBrushBlack = new SolidBrush(Color.Black);

            // Draw grid to make it easier to position lines
            //for (int i = 0; i < this.Height / 10; i++)
            //{
            //    for (int j = 0; j < this.Width / 10; j++)
            //    {
            //        graphicsObj.DrawRectangle(myPen, j * 10, i * 10, 1, 1);
            //    }
            //}

            myPen.Width = 1;

            //this code draws the shape of the sun on the corner of the page
            graphicsObj.DrawPolygon(myPenYellow, new Point[] { new Point(0, 0), new Point(0, 50), new Point (30, 40), new Point(40, 30), new Point (50,0) });
            graphicsObj.FillPolygon(myBrushYellow , new Point[] { new Point(0, 0), new Point(0, 50), new Point(30, 40), new Point(40, 30), new Point(50, 0) });

            //This code draws the rays of sun as lines with the yellow pen
            graphicsObj.DrawLine(myPenYellow, new Point(10, 60), new Point(20, 80) );
            graphicsObj.DrawLine(myPenYellow, new Point(30, 50), new Point(60, 80));
            graphicsObj.DrawLine(myPenYellow, new Point(50, 30), new Point(70, 40));
            graphicsObj.DrawLine(myPenYellow, new Point(60, 10), new Point(110, 10));

            //This code draws the tail flippers
            graphicsObj.DrawPolygon(myPenDarkGray, new Point[] { new Point(130, 270), new Point(120, 250), new Point(100, 240), new Point(90, 260), new Point(100, 270), new Point (120, 280), new Point(110,310), new Point (120,330), new Point (140,310), new Point (140, 280), new Point (130,280) });
            graphicsObj.FillPolygon(myBrush, new Point[] { new Point(130, 270), new Point(120, 250), new Point(100, 240), new Point(90, 260), new Point(100, 270), new Point(120, 280), new Point(110, 310), new Point(120, 330), new Point(140, 310), new Point(140, 280), new Point(130, 280) });

            //This code draws a polygon of the outline of the body.
            graphicsObj.DrawPolygon(myPenDarkGray, new Point[] { new Point(140, 280), new Point(160, 270), new Point(180, 260), new Point(210, 230), new Point(230, 200), new Point(240, 180), new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point (230, 140), new Point(240, 140),
                new Point(240, 130), new Point(220, 90), new Point(210, 80), new Point (200, 70), new Point (180, 60), new Point (170, 60), new Point (140, 70), new Point (120, 90), new Point (110, 100), new Point (100, 120), new Point (100, 140),  new Point (80, 160), new Point (80, 170),
                new Point (90, 170), new Point (110, 160), new Point (130, 160), new Point (150, 150), new Point (165, 145), new Point (180, 150), new Point (190, 170), new Point (190, 200), new Point (180, 220), new Point (170, 240), new Point (130, 270), new Point (130, 280) });
            graphicsObj.FillPolygon(myBrush, new Point[] {new Point(140, 280), new Point(160, 270), new Point(180, 260), new Point(210, 230), new Point(230, 200), new Point(240, 180), new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point (230, 140), new Point(240, 140),
                new Point(240, 130), new Point(220, 90), new Point(210, 80), new Point (200, 70), new Point (180, 60), new Point (170, 60), new Point (140, 70), new Point (120, 90), new Point (110, 100), new Point (100, 120), new Point (100, 140),  new Point (80, 160), new Point (80, 170),
                new Point (90, 170), new Point (110, 160), new Point (130, 160), new Point (150, 150), new Point (165, 145), new Point (180, 150), new Point (190, 170), new Point (190, 200), new Point (180, 220), new Point (170, 240), new Point (130, 270), new Point (130, 280) });

            //this code draws the line for the mouth of the dolphin
            graphicsObj.DrawLine(myPenDarkGray, new Point (110, 160), new Point (150, 140) );
            graphicsObj.DrawLine(myPenDarkGray, new Point (150, 140), new Point (160, 120) );

            // this code draws the left fin of the dolphin in a darker gray because it is supposed to be shaded
            graphicsObj.DrawPolygon(myPenDarkGray, new Point[] { new Point (180, 150), new Point(165, 165), new Point(160, 190), new Point(180, 170), new Point(190, 170) });
            graphicsObj.FillPolygon(myBrush, new Point[] { new Point(180, 150), new Point(165, 165), new Point(160, 190), new Point(180, 170), new Point(190, 170) });

            // this code draws the right fin on the dolphin
            graphicsObj.DrawPolygon(myPenDarkGray, new Point[] { new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point(230, 140), new Point(240, 140), new Point(260, 150), new Point(270, 160), new Point(280, 190), new Point(250,170) });
            graphicsObj.FillPolygon(myBrush, new Point[] { new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point(230, 140), new Point(240, 140), new Point(260, 150), new Point(270, 160), new Point(280, 190), new Point(250, 170) });

            //this code draws the white belly the dolphin
            graphicsObj.DrawPolygon(myPenWhite, new Point[] { new Point(180, 150), new Point(190, 170), new Point(190, 200), new Point(180, 220), new Point(170, 240), new Point(190, 230), new Point(200, 210), new Point(210, 180), new Point(200, 160), new Point(190, 150) });
            graphicsObj.FillPolygon(myBrushWhite, new Point[] { new Point(180, 150), new Point(190, 170), new Point(190, 200), new Point(180, 220), new Point(170, 240), new Point(190, 230), new Point(200, 210), new Point(210, 180), new Point(200, 160), new Point(190, 150) });

            //this code draws the big drop of water to the right of the dolphin
            graphicsObj.DrawPolygon(myPenBlue, new Point[] { new Point(160, 330), new Point(180, 300), new Point(200, 290), new Point(210, 300), new Point(200, 310) });
            graphicsObj.FillPolygon(myBrushBlue, new Point[] { new Point(160, 330), new Point(180, 300), new Point(200, 290), new Point(210, 300), new Point(200, 310) });

            //this code draws the little drop of water on the left of the dolphin
            graphicsObj.DrawPolygon(myPenBlue, new Point[] { new Point(60, 260), new Point(65, 275), new Point(60, 300), new Point(55, 275) });
            graphicsObj.FillPolygon(myBrushBlue, new Point[] { new Point(60, 260), new Point(65, 275), new Point(60, 300), new Point(55, 275) });

            //this code draws the splash of water for the dolphin juping out of the water
            graphicsObj.DrawPolygon(myPenBlue, new Point[] { new Point (0, 390), new Point(0, 370), new Point(10, 350), new Point(10, 330), new Point(20, 330), new Point(30, 350), new Point(30, 360), new Point(50, 380), new Point(60, 380), new Point(70, 370), new Point(70, 350),
                new Point (80, 360), new Point (80, 370), new Point (90, 370), new Point (100, 360), new Point (110, 370), new Point (120, 380), new Point (130, 380), new Point (130, 380), new Point (150, 370), new Point (170, 360), new Point (190, 360), new Point (210, 350),
                new Point (220, 330), new Point (240, 310), new Point (250, 310), new Point (240, 330), new Point (220, 360), new Point (230, 380), new Point (310, 390) });
            graphicsObj.FillPolygon(myBrushBlue, new Point[] {new Point (0, 390), new Point(0, 370), new Point(10, 350), new Point(10, 330), new Point(20, 330), new Point(30, 350), new Point(30, 360), new Point(50, 380), new Point(60, 380), new Point(70, 370), new Point(70, 350),
                new Point (80, 360), new Point (80, 370), new Point (90, 370), new Point (100, 360), new Point (110, 370), new Point (120, 380), new Point (130, 380), new Point (130, 380), new Point (150, 370), new Point (170, 360), new Point (190, 360), new Point (210, 350),
                new Point (220, 330), new Point (240, 310), new Point (250, 310), new Point (240, 330), new Point (220, 360), new Point (230, 380), new Point (310, 390) });

            //this code draws the line across the dorsal fin of the dolphin to give it its shape
            graphicsObj.DrawPolygon(myPenDarkGray, new Point[] { new Point(210, 80), new Point(200, 70), new Point(180, 60), new Point(170, 60), new Point(200, 40), new Point(230, 35), new Point(220, 50), new Point(210, 70) });
            graphicsObj.FillPolygon(myBrush, new Point[] { new Point(210, 80), new Point(200, 70), new Point(180, 60), new Point(170, 60), new Point(200, 40), new Point(230, 35), new Point(220, 50), new Point(210, 70) });
            graphicsObj.DrawLine(myPenDarkGray, new Point(170, 60), new Point(180,60));
            graphicsObj.DrawLine(myPenDarkGray, new Point(180, 60), new Point(200, 70));
            graphicsObj.DrawLine(myPenDarkGray, new Point(200, 70), new Point(210, 80));

            //this set of lines draws the outline of the right fin to differentiate it from the body of the dolphin
            graphicsObj.DrawLine(myPenDarkGray, new Point(240, 140), new Point(230, 140));
            graphicsObj.DrawLine(myPenDarkGray, new Point(230, 140), new Point(220, 160));
            graphicsObj.DrawLine(myPenDarkGray, new Point(220, 160), new Point(230, 180));
            graphicsObj.DrawLine(myPenDarkGray, new Point(230, 180), new Point(240, 170));

            //this code draws the eye of the dolphin, one circle for the white part, one circle for the little part.
            graphicsObj.DrawEllipse(myPen, new Rectangle(130, 110, 10, 10));
            graphicsObj.FillEllipse(myBrushWhite, new Rectangle(130, 110, 10, 10));
            graphicsObj.DrawEllipse(myPen, new Rectangle(130, 110, 5, 5));
            graphicsObj.FillEllipse(myBrushBlack, new Rectangle(130, 110, 5, 5));

            //this code draws the line on the nose of the dolphin to give it depth and dimension
            graphicsObj.DrawLine(myPenDarkGray, new Point (100, 140), new Point (110, 140));

            // Add Text
            Font myFont = new Font("Georgia", 16.0f);
            myBrush = new SolidBrush(Color.Red);
            graphicsObj.DrawString("David the Dolphin", myFont, myBrush, new Point(50, 390));
            graphicsObj.DrawString("by Omar Enriquez", myFont, myBrush, new Point(50, 410));

            myPen.Dispose();
            myBrush.Dispose();
            graphicsObj.Dispose();

        }
    }
}
