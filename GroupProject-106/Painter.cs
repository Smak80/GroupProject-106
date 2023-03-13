using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Graph_painting
{
    public class Painter
    {
        private PointF[] points;
        private Size containerSize;
        private Graphics mainGraphics;

        private double X;
        private double Y;

        private double Ymax=10;
        private double Ymin=-10;

        private double multiplierX;
        private double multiplierY;

        private double step = 1;

        private double diffX;
        private double diffY;

        private bool isCorrectInput=true;

        private int k=0;

        private static Brush brush = new SolidBrush(Color.Black);
        private static Brush brushR = new SolidBrush(Color.Red);
        private Pen p = new Pen(brush, 2);

        public Size ContainerSize
        {
            get => containerSize;
            set
            {
                containerSize = value;
            }
        }

        public Painter(Graphics MainGraphics)
        {
            mainGraphics = MainGraphics;
            ContainerSize = mainGraphics.VisibleClipBounds.Size.ToSize();
            X = ContainerSize.Width / 2;
            Y = ContainerSize.Height / 2;
        }
        //Init Coordinate plane

        public void initCoord(double L, double U, double Up, double D, double step)
        {
            if ((L < U && Up > D))
            {
                mainGraphics.Clear(Color.White);
                points = new PointF[1];

                this.step = step == 0.0 ? 1 : step;
                Ymax = Up;
                Ymin = D;

                diffX = Math.Abs(U - L) / 1;
                diffY = (Math.Abs(Ymax) + Math.Abs(Ymin)) / 1;

                multiplierX = containerSize.Width / diffX;
                multiplierY = containerSize.Height / diffY;

                if (U < 0 && L < 0) X = X = -L * multiplierX;
                else if (U > 0 && L > 0) X = -L * multiplierX;
                else X = Math.Abs((double)((L) / (U - L))) * containerSize.Width;

                Y = Math.Abs(Ymax) / (Math.Abs(Ymax) + Math.Abs(Ymin)) * containerSize.Height;
                isCorrectInput = true;
            }
            else isCorrectInput = false;

        }
        public void PaintCordPlane(double L, double U, double Up, double D, double step,bool z)
        {
            //
            if (isCorrectInput) 
            {
                // draw X-line
                mainGraphics.DrawLine(p, 0, (int)Y, containerSize.Width, (int)Y);

                // draw Y-line
                if (L <= 0 && U >= 0)
                {
                    mainGraphics.DrawLine(p, (int)X, 0, (int)X, containerSize.Height);
                    drawLines(X, p, diffY);
                }
                else if (L > 0 && U > 0)
                {
                    drawLines(0, p, diffY);
                }
                else if (U < 0 && L < 0)
                {
                    drawLines(containerSize.Width, p, diffY);
                }

                //draw x lines
                double c = 0;
                double cond;
                if (multiplierX >= 50) cond = 1;
                else if (multiplierX <= 5) cond = 10;
                else cond = Math.Round(multiplierX);
                for (double i = 0; i <= containerSize.Width; i += multiplierX)
                {

                    if (c == cond || i == 0)
                    {
                        mainGraphics.DrawLine(p, (int)(i), (int)(Y - 10), (int)(i), (int)(Y + 10));
                        mainGraphics.DrawString(Math.Round(L + 1 * i / multiplierX, 2).ToString(), Control.DefaultFont, brush, new Point((int)i, (int)(Y + 15)));
                        c = 0;
                    }
                    mainGraphics.DrawLine(p, (int)(i), (int)(Y - 5), (int)(i), (int)(Y + 5));
                    c++;
                } 
            }
            
        }
        // Paintintg Graph
        public void PaintGraph(double x, double y)
        {
            if (isCorrectInput)
            {
                Array.Resize(ref points, k + 2);
                points.SetValue(new PointF((float)(X + x * multiplierX), (float)(Y - (y) * multiplierY)), points.Length - 1);
                if (k == 0) points.SetValue(new PointF((float)(X + x * multiplierX), (float)(Y - (y) * multiplierY)), 0);
                PointF[] pois = new PointF[2] { points[points.Length - 2], points[points.Length - 1] };
               
                k++;
                mainGraphics.FillRectangle(brushR, (int)(X + x * multiplierX), (int)(Y - (y < 0 ? 0 : y * multiplierY)), (int)(step * multiplierX) < 1 ? 1 : (int)(step * multiplierX), (int)(Math.Abs(y) * multiplierY));
            }
            
        }

        public void drawCurve()
        {
            if(points.Length != 0) mainGraphics.DrawCurve(p, points);
        }

        public void drawLines(double cond,Pen p,double dY)
        {
            var a = p.Brush;
            double c = 0;
            double condit;

            double upperDiff = Y / Ymax;

            if (upperDiff >= 25) condit = 1;
            else if (upperDiff <= 5) condit = 10;
            else condit = Math.Round(upperDiff);

            

            for (double i = 0; i <= Y; i += upperDiff)
            {
                if (c == condit||i==0)
                {

                        mainGraphics.DrawLine(p, (int)cond - 10, (int)i, (int)cond + 10, (int)i);
                        mainGraphics.DrawString(Math.Round(Ymax - i / upperDiff, 2).ToString(), Control.DefaultFont, a, new Point((int)(cond <= 0 ? 40 : cond - 40), (int)i));
                    c = 0;
                }
                else
                {
                    mainGraphics.DrawLine(p,(int) cond-5, (int)i, (int)cond+5, (int)i);
                }
                c++;
            }

            double condit2;

            double lowerDiff = containerSize.Height / 2 / Math.Abs(Ymin);
            if (lowerDiff >= 25) condit2 = 1;
            else if (lowerDiff <= 5) condit2 = 10;
            else condit2 = Math.Round(lowerDiff);



            for (double i = containerSize.Height;i>Y ; i -= lowerDiff)
            {
                if (c == condit2 || i == containerSize.Height)
                {

                    mainGraphics.DrawLine(p, (int)cond - 10, (int)i, (int)cond + 10, (int)i);
                    double res = -Math.Round(Ymin + i / lowerDiff, 2);
                    mainGraphics.DrawString(Math.Round(res).ToString(), Control.DefaultFont, a, new Point((int)(cond <= 0 ? 40 : cond - 40), (int)i));
                    c = 0;
                }
                else
                {
                    mainGraphics.DrawLine(p, (int)cond - 5, (int)i, (int)cond + 5, (int)i);
                }
                c++;
            }
        }
    }
}