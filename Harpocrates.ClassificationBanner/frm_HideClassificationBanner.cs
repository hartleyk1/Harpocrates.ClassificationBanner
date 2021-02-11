/***********************************************************************************
 * 
 * Copyright:   Kellye Tolliver, tolliver.kellye@gmail.com
 * File Name:   frm_HideClassificationBanner
 * Modified:    2021-02-02
 * Purpose:     Set up timers to control the display of message dialog and 
 *      classification banner. Determine if classification banner is displayed,
 *      based upon timer's start and stop, toggle the banner's display.
 *      
 *      tmr_Hide = 15 minutes / 900 seconds / 900000 milliseconds
 *      tmr_Message = 3 seconds / 3000 milliseconds
 * 
 * *********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harpocrates.ClassificationBanner
{
    public partial class frm_HideClassificationBanner : Form
    {

        /// <summary>
        /// Default constructor, loads the form and sets the location of the form.
        /// </summary>
        public frm_HideClassificationBanner()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.ShowDialog();
        }

        /// <summary>
        /// Checks if banner form exists, if so then close the banner.
        /// Displays the dialog message to the user and begins the timers.
        /// </summary>
        private void frm_HideClassificationBanner_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ClassificationBanner>().Any())
            {
                //Application.OpenForms.OfType<frm_ClassificationBanner>().FirstOrDefault().Hide();
            }
            tmr_Hide.Start();
            tmr_Message.Start();
        }

        #region Timers
        /// <summary>
        /// Timer that controls the visibility of the banner. 
        /// When timer stops, reload/initialize banner.
        /// </summary>
        private void tmr_Hide_Tick(object sender, EventArgs e)
        {
            tmr_Hide.Stop();
            Console.WriteLine("Stopped hiding");
            frm_ClassificationBanner banner = new frm_ClassificationBanner();   // Initializes form
            banner.Show();  // shows form
        }

        /// <summary>
        /// Timer that controls the visiblity of the message.
        /// When timer stops, hide the message.
        /// </summary>
        private void tmr_Message_Tick(object sender, EventArgs e)
        {
            tmr_Message.Stop();
            Console.WriteLine("Stopped message");
            this.Visible = false;
            Application.OpenForms.OfType<frm_ClassificationBanner>().First().Hide(); // Hides form from being displayed, does not re-register
        }
        #endregion
    }
}
