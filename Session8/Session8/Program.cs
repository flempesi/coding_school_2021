using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        //ClassQuestion2 question2 = new ClassQuestion2();
        //Console.WriteLine("Question2\n");
        //    Professor professor = new Professor();
        //professor.Name = "Myname";
        //    Console.WriteLine("The name of the professor that i entered is {0}", professor.GetName());
    }
}
