﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TurtleForm
{
    class Canvas
    {
        Graphics g;
        Pen Pen;
        int xPos, yPos;


        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 3);
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }

        public void DrawSquare(int width)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + width, yPos + width);
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
        }

        public void ColorRed(Color red)
        {
            Pen pen = new Pen(Color.Red, 3);
        }

    }
}
