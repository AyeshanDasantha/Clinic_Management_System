using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinic_Management_System.form;
using Clinic_Management_System.Zoom_Chart;

namespace Clinic_Management_System
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
            Application.Run(new splash());
        }
    }
}
