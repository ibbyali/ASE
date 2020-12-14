using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TurtleForm

    //class where we create all the functions that will be classed from cmd class
{
    class Canvas
    {
        Graphics g;
        Pen Pen;
        SolidBrush Brush = new SolidBrush(Color.Black);
        int xPos, yPos;
        int penheight = 7;
        int penlength = 7;
        variables localV = new variables();
        Boolean fill;


        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 3);
            g.DrawRectangle(Pen, xPos, yPos, penheight, penlength);
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        public void DrawSquare(int length)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + length, yPos + length);
        }

        public void DrawRectangle(int length, int height)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + length, yPos + height);

            if(fill == false)
            {
                g.DrawRectangle(Pen, xPos, yPos, xPos + length, yPos + height);
            }
            else if(fill == true)
            {
                g.FillRectangle(Brush, xPos, yPos, xPos + length, yPos + height);
            }
        }

        public void DrawTriangle(int length)
        {
            this.DrawLine(xPos, yPos + length);
            this.DrawLine(xPos + length, yPos);
            this.DrawLine(xPos - length, yPos - length);
        }

        public void DrawCircle(int radius)
        {
            g.DrawEllipse(Pen, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));

            

            if (fill == false)
            {
                g.DrawEllipse(Pen, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));
            }
            else if (fill == true)
            {
                g.FillEllipse(Brush, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));
            }
        }

        public void PenColor(Color color)
        {
            Pen = new Pen(color, 3);
        }

        public void MoveTo(int x, int y)
        {
            xPos = x;
            yPos = y;

            g.DrawRectangle(Pen, xPos, yPos, penheight, penlength);

        }

        public void DrawTo(int x, int y)
        {

            g.DrawRectangle(Pen, xPos, yPos, penheight, penlength);
            g.DrawLine(Pen, xPos, yPos, x, y);
            xPos = x;
            yPos = y;
        }

        public void ClearWindow()
        {
            g.Clear(Color.White);
            g.DrawRectangle(Pen, xPos, yPos, penheight, penlength);

        }

        public void Fillstate(Boolean e)
        {
            fill = e;
        }

        public void FillOff()
        {

        }
    }
}
