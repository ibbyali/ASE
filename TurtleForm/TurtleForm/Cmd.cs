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
        String Command;
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
            line = line.ToLower().Trim();
            split = line.Split(' ');

            Command = split[0];
            if (split.Length > 1)
            {
                parameters = split[1].Split(',');
                for(int i=0; i < parameters.Length; i++)
                {
                    intparameters[i] = int.Parse(parameters[i]);
                }
            }

            if (Command.Equals("line") == true)
            {
                MainCanvas.DrawLine(intparameters[0],intparameters[1]);
                Console.WriteLine("LINE");
            }
            else if (Command.Equals("square") == true)
            {
                MainCanvas.DrawSquare(intparameters[0]);
                Console.WriteLine("SQUARE");
            }
            else if (Command.Equals("circle") == true)
            {
                MainCanvas.DrawCircle(intparameters[0]);
                Console.WriteLine("CIRCLE");
            }
            else if (Command.Equals("triangle") == true)
            {
                MainCanvas.DrawTriangle(intparameters[0]);
                Console.WriteLine("TRIANGLE");
            }
            else if (Command.Equals("run") == true)
            {

                Console.WriteLine("MultiLine");
            }
        }

    }

    
}
