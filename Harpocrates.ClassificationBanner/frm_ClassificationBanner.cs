using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Harpocrates.ClassificationBanner
{
    public partial class frm_ClassificationBanner : Form
    {
        // variables for class declaration
        /* private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
         private const UInt32 SWP_NOSIZE = 0x0001;
         private const UInt32 SWP_NOMOVE = 0x0002;
         private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;*/
        // Add prototype for user32.ddl function
        /* [DllImport("user32.dll")]
         [return: MarshalAs(UnmanagedType.Bool)]
         public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
         /// <summary>
         /// Load frm_ClassificationBanner windows form
         /// </summary>
          */

        public frm_ClassificationBanner()
        {
            InitializeComponent();
            /** Banner width **/
            // Retrieve the working rectangle from the Screen class
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, 30);
            // Ensure the location of the form has not changed
            this.Location = new Point(0, 0);
            /** User Label **/
            lbl_User.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            /** Computer Label **/
            lbl_Computer.Text = Environment.MachineName;
            //pictureBox1.Image = Image.FromFile("../Pics/image1.jpg"); 
            // Sets frm_ClassificationBanner to always be on top
            // this.TopMost = true;
            this.ShowDialog();
            RegisterBar();
            // SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
    }
}
