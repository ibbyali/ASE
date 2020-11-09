using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TurtleForm
{
    public partial class execute : Form
    {
        Bitmap OutputBitmap = new Bitmap(466, 566);
        Canvas MainCanvas;
        Cmd Commands;
        public execute()
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


                commandLineBox.Text = "";
                Refresh();
                if (line.Equals("run") == true)
                {

                    using (StringReader reader = new StringReader(multiLineCmd.Text))  //this what allows program to reach each line as a string in richtextbox
                    {
                        String richTextLine;
                        while ((richTextLine = reader.ReadLine()) != null)  //while loop runs untill its read each line of the richtextbox
                        {
                            Commands.parseCommands(richTextLine);
                        }
                    }
                    Console.WriteLine("MultiLine");
                }
                else
                {
                    Commands.parseCommands(line);
                }
            }
        }

        private void drawBox_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";   //when dialog box is open .txt file is preset ready to save

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                multiLineCmd.Text = read.ReadToEnd();
                read.Dispose();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Text Files (*.txt)|*.txt| AllowDrop Files(*.*)|*.*";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(multiLineCmd.Text);  //read from richtextbox and save it as file
                write.Dispose();
            }
        }

        private void multiLineCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
