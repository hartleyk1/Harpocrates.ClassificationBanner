using System;
using System.Drawing;
using System.Windows.Forms;

namespace Harpocrates.ClassificationBanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /** Banner width **/
            // Retrieve the working rectangle from the Screen class
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, 15);
            // Ensure the location of the form has not changed
            this.Location = new Point(0, 0);
            /** User Label **/
            lbl_User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            /** Computer Label **/
            lbl_Computer.Text = Environment.MachineName;
        }
    }
}
