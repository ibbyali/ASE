﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TurtleForm

    //class where we create all the functions that will be classed from cmd class
{   /// <summary>
    /// Declaration of variables
    /// </summary>
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
        /// <summary>
        /// Takes both parameters of intparameter array and sets it to 'toY' and 'toY' which draws a line
        /// </summary>
        /// <param name="toX"></param>
        /// <param name="toY"></param>
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }
        /// <summary>
        /// Takes intparameter and set it as length and the function creates the square
        /// </summary>
        /// <param name="length"></param>
        public void DrawSquare(int length)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + length, yPos + length);

            if(fill == false)
            {
                g.DrawRectangle(Pen, xPos, yPos, xPos + length, yPos + length);
            }
            else if(fill == true)
            {
                g.FillRectangle(Brush, xPos, yPos, xPos + length, yPos + length);
            }
        }
        /// <summary>
        /// Takes intparameter and set both parameters to length and height and that creates the function for rectangle
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
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
        /// <summary>
        /// Takes intparameter and set it as length and the function creates the triangle
        /// </summary>
        /// <param name="length"></param>
        public void DrawTriangle(int length)
        {
            this.DrawLine(xPos, yPos + length);
            this.DrawLine(xPos + length, yPos);
            this.DrawLine(xPos - length, yPos - length);
        }
        /// <summary>
        /// Takes intparameter and set it as radis of circle and function create the circle
        /// </summary>
        /// <param name="radius"></param>
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
        /// <summary>
        /// sets new pen when it is called
        /// </summary>
        /// <param name="color"></param>
        public void PenColor(Color color)
        {
            Pen = new Pen(color, 3);
        }
        /// <summary>
        /// Sets new pen location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
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
        /// <summary>
        /// this functions clears the picture box
        /// </summary>
        public void ClearWindow()
        {
            g.Clear(Color.White);
            g.DrawRectangle(Pen, xPos, yPos, penheight, penlength);

        }
        /// <summary>
        /// makes the fill variable a boolean
        /// </summary>
        /// <param name="e"></param>
        public void Fillstate(Boolean e)
        {
            fill = e;
        }

    }
}
