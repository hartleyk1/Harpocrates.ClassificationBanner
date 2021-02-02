/***********************************************************************************
 * 
 * Copyright:   Kellye Tolliver, tolliver.kellye@gmail.com
 * File Name:   Program
 * Modified:    2020-01-20
 * Purpose:     Initial start up/load of the windows banner.
 * 
 * *********************************************************************************/


using System;
using System.Windows.Forms;

namespace Harpocrates.ClassificationBanner
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
            Application.Run(new frm_ClassificationBanner());
        }

    }
}
