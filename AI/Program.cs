using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sieć
{
    static class Program
    {
        private static Form1 form1;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Application.Run(form1);
        }

        public static Form1 getForm1()
        {
            return form1;
        }
    }
}
