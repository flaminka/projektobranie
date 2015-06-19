using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CSS
{
    static class Program
    {
         public static Form1 mainform; //main window reference

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
            Application.Run(mainform = new Form1());//   Application.Run(new Form1());
        }
    }
}

   

