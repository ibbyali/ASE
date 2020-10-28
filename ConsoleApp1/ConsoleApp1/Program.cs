using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            Program app = new Program();
            app.go();
            MessageBox.Show("Test", "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show("Test1", "Title1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void go()
        {
            Console.WriteLine("in go");
        }
    }
}
