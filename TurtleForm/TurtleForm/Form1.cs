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
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(466, 566);
        Canvas MainCanvas;
        Cmd Commands;
        public Form1()
        {
            InitializeComponent();
            MainCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
            Commands = new Cmd(MainCanvas);
        }


        private void drawBox_Click(object sender, EventArgs e)
        {
        
        }

        private void commandLineBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void commandLineBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("Return pressed");

                String line = commandLineBox.Text;
                Commands.parseCommands(line);

                commandLineBox.Text = "";
                Refresh();
            }
        }

        private void drawBox_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }
    }
}
