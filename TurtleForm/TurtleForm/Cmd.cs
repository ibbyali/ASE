﻿using System;
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

        /// <summary>
        /// Takes input from user and trims and split line is they is a space
        /// first split stores in command and get checked if it a valid command and executes the correct function
        /// second split gets stored in parameter array which is the expected result of the command if needed
        /// within paramater if they is a "," each number gets stored in a space of intparameter array
        /// </summary>
        /// <param name="line"></param>
        public void parseCommands(String line)
        {
            line = line.ToLower().Trim();    //this takes the input from user trims, and split if they is a space
            split = line.Split(' ');

            Command = split[0]; //puts the first half of the split and stores it as a command 
            if (split.Length > 1)    //if they is more than one piece of data in the split array run the If statement
            {

                parameters = split[1].Split(',');   //split the coordinates put them into integers array
                
                if (split[0] != "pen" || split[0] != "fill")
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        try
                        {
                            intparameters[i] = int.Parse(parameters[i]);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine("Invalid parameter!\nE.g: line 100,100", "Error!" + e.Message);
                            //MessageBox.Show("Invalid Command", "Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    //Commands
                    try
                    {
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

                        else if (Command.Equals("rect") == true)
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
                            if (parameters[0].Equals("blue"))
                            {
                                MainCanvas.PenColor(Color.Blue);
                            }
                            if (parameters[0].Equals("yellow"))
                            {
                                MainCanvas.PenColor(Color.Yellow);
                            }
                            Console.WriteLine("Pen colour changed");
                        }
                        else if (Command.Equals("moveto") == true)
                        {
                            MainCanvas.MoveTo(intparameters[0], intparameters[1]);
                            Console.WriteLine("You have moved");
                        }
                        else if (Command.Equals("drawto") == true)
                        {
                            MainCanvas.DrawTo(intparameters[0], intparameters[1]);
                            Console.WriteLine("You have drawn");
                        }
                        else if (Command.Equals("fill") == true)
                        {
                            if (parameters[0].Equals("on"))
                            {
                                MainCanvas.Fillstate(true);
                                //Console.Write("Fill is On");
                            }
                            if (parameters[0].Equals("off"))
                            {
                                MainCanvas.Fillstate(false);
                                //Console.Write("Fill is Off");
                            }
                            Console.WriteLine("fill change");
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
                        else if (Command.Equals("if") == true)
                        {
                            //if (parameters[0])
                            //{

                            //}
                        }
                        else if (Command.Equals("loop") == true)
                        {
                            //for (int i = 0; i < intparameters[0]; i++)
                            //{

                            //}
                        }
                        else if (Command.Equals("end") == true)
                        {

                        }
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine("This exception is " + e.Message);
                        MessageBox.Show("Invalid Command", "Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
        }//END parsecommands


    }//END cmd


}//END namespace
