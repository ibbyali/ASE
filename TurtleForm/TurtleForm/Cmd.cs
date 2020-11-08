using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleForm
{
    class Cmd
    {
        String[] split;
        String Command;                 //all the global variables
        String[] parameters;
        int[] intparameters;
        Canvas MainCanvas;

        public Cmd(Canvas MainCanvas)
        {
            this.MainCanvas = MainCanvas;
            intparameters = new int[2];
        }

        public void parseCommands(String line)
        {
            line = line.ToLower().Trim();    //this takes the input from user trims, and split if they is a space
            split = line.Split(' ');

            Command = split[0];    //puts the first half of the split and stores it as a command 
            if (split.Length > 1)    //if they is more than one piece of data in the split array run the If statement
            {

                parameters = split[1].Split(',');   //split the coordinates put them into integers array

                if (split[0] != "pen")
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        intparameters[i] = int.Parse(parameters[i]);
                    }
                }
            }

            //Commands

            if (Command.Equals("line") == true)
            {
                MainCanvas.DrawLine(intparameters[0], intparameters[1]);
                MainCanvas.MoveTo(intparameters[0], intparameters[1]);
                Console.WriteLine("LINE");
            }
            else if (Command.Equals("square") == true)
            {
                MainCanvas.DrawSquare(intparameters[0]);
                Console.WriteLine("SQUARE");
            }
            else if (Command.Equals("rectangle") == true)
            {
                MainCanvas.DrawRectangle(intparameters[0], intparameters[1]);
                MainCanvas.MoveTo(intparameters[0], intparameters[1]);
                Console.WriteLine("Rectangle");
            }
            else if (Command.Equals("circle") == true)
            {
                MainCanvas.DrawCircle(intparameters[0]);
                MainCanvas.MoveTo(intparameters[0], intparameters[1]);
                Console.WriteLine("CIRCLE");
            }
            else if (Command.Equals("triangle") == true)
            {
                MainCanvas.DrawTriangle(intparameters[0]);
                Console.WriteLine("TRIANGLE");
            }
            else if (Command.Equals("pen") == true)
            {
                if (parameters[0].Equals("red"))
                {
                    MainCanvas.PenColor(Color.Red);
                }
                if (parameters[0].Equals("black"))
                {
                    MainCanvas.PenColor(Color.Black);
                }
                Console.WriteLine("Pen colour changed");
            }
            else if (Command.Equals("moveto") == true)
            {
                MainCanvas.MoveTo(intparameters[0], intparameters[1]);
                Console.WriteLine("You have moved");
            }
            else if (Command.Equals("run") == true)
            {

                Console.WriteLine("MultiLine");
            }
            else if (Command.Equals("reset") == true)
            {
                MainCanvas.ClearWindow();
                MainCanvas.MoveTo(0, 0);

            }
            else if (Command.Equals("clear") == true)
            {
                MainCanvas.ClearWindow();
            }


        }


    }


}
