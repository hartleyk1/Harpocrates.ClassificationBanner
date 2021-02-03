/***********************************************************************************
 * 
 * Copyright:   Kellye Tolliver, tolliver.kellye@gmail.com
 * File Name:   frm_ClassificationBanner
 * Modified:    2021-02-02
 * Purpose:     Set up defaults of the banner settings and then begin the loading
 *      and registration of the banner. Banner must be registered as an application
 *      bar for it to be able to take over the top portion of the user's screen.
 *      Next, retrieve the user's current information and, based on the returned
 *      data, modify the banner.
 * 
 * *********************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using Microsoft.Win32;

namespace Harpocrates.ClassificationBanner
{
    public partial class frm_ClassificationBanner : Form
    {
        #region Constant Banner Variables
        private string U = "#007a33";
        private string U_TEXT = "UNCLASSIFIED";
        private string ULES = "#007a33";
        private string ULES_TEXT = "UNCLASSIFIED // LAW ENFORCEMENT SENSITIVE";
        private string UFUO = "#007a33";
        private string UFUO_TEXT = "UNCLASSIFIED // FOR OPERATIONAL USE ONLY";
        private string CON = "#0033A0";
        private string CON_TEXT = "CONFIDENTIAL";
        private string C = "#c1a7e2";
        private string C_TEXT = "CLASSIFIED";
        private string S = "#C8102E";
        private string S_TEXT = "SECRET";
        private string TS = "#FF671F";
        private string TS_TEXT = "TOP SECRET";
        private int closingFlag = 0;
        private int hidingFlag = 0;
        private string userRole;
        private int bannerCount = 0;
        #endregion

        #region Initialize Banner
        /// <summary>
        /// Initializes the consturction of the form/banner,
        /// retrieves the user's current information, and executes registration of the banner
        /// </summary>
        public frm_ClassificationBanner()
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

            // Banner Controls
            btnClose.Image = Image.FromFile(@"../../Images/close.png");
            btnHide.Image = Image.FromFile(@"../../Images/visible.png");
            btnChange.Image = Image.FromFile(@"../../Images/level.png");
            btnAbout.Image = Image.FromFile(@"../../Images/help.png");

            
        }
        #endregion

        #region Set Up Default Banner
        /// <summary>
        /// Based on the user's information, modify the banner based on their
        /// level/user group.
        /// </summary>
        /// <param name="userGroup">Obtain the group that the user belongs to within their directory</param>
        /// <param name="domainPath">Obtain the network domain that the user is a part of</param>
        private void ClassifyUser(string userGroup, string domainPath, int level)
        {
            if (level > 0 && level < 7)
            {
                switch (level)
                {
                    case 1:
                        lbl_Classification.Text = ULES_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(ULES);
                        btnClose.BackColor = ColorTranslator.FromHtml(ULES);
                        btnHide.BackColor = ColorTranslator.FromHtml(ULES);
                        btnChange.BackColor = ColorTranslator.FromHtml(ULES);
                        btnAbout.BackColor = ColorTranslator.FromHtml(ULES);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(ULES);
                        lbl_User.BackColor = ColorTranslator.FromHtml(ULES);
                        break;
                    case 2:
                        lbl_Classification.Text = UFUO_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(UFUO);
                        btnClose.BackColor = ColorTranslator.FromHtml(UFUO);
                        btnHide.BackColor = ColorTranslator.FromHtml(UFUO);
                        btnChange.BackColor = ColorTranslator.FromHtml(UFUO);
                        btnAbout.BackColor = ColorTranslator.FromHtml(UFUO);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(UFUO);
                        lbl_User.BackColor = ColorTranslator.FromHtml(UFUO);
                        break;
                    case 3:
                        lbl_Classification.Text = CON_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(CON);
                        btnClose.BackColor = ColorTranslator.FromHtml(CON);
                        btnHide.BackColor = ColorTranslator.FromHtml(CON);
                        btnChange.BackColor = ColorTranslator.FromHtml(CON);
                        btnAbout.BackColor = ColorTranslator.FromHtml(CON);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(CON);
                        lbl_User.BackColor = ColorTranslator.FromHtml(CON);
                        break;
                    case 4:
                        lbl_Classification.Text = C_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(C);
                        btnClose.BackColor = ColorTranslator.FromHtml(C);
                        btnHide.BackColor = ColorTranslator.FromHtml(C);
                        btnChange.BackColor = ColorTranslator.FromHtml(C);
                        btnAbout.BackColor = ColorTranslator.FromHtml(C);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(C);
                        lbl_User.BackColor = ColorTranslator.FromHtml(C);
                        break;
                    case 5:
                        lbl_Classification.Text = S_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(S);
                        btnClose.BackColor = ColorTranslator.FromHtml(S);
                        btnHide.BackColor = ColorTranslator.FromHtml(S);
                        btnChange.BackColor = ColorTranslator.FromHtml(S);
                        btnAbout.BackColor = ColorTranslator.FromHtml(S);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(S);
                        lbl_User.BackColor = ColorTranslator.FromHtml(S);
                        break;
                    case 6:
                        lbl_Classification.Text = TS_TEXT;
                        lbl_Classification.BackColor = ColorTranslator.FromHtml(TS);
                        btnClose.BackColor = ColorTranslator.FromHtml(TS);
                        btnHide.BackColor = ColorTranslator.FromHtml(TS);
                        btnChange.BackColor = ColorTranslator.FromHtml(TS);
                        btnAbout.BackColor = ColorTranslator.FromHtml(TS);
                        lbl_Computer.BackColor = ColorTranslator.FromHtml(TS);
                        lbl_User.BackColor = ColorTranslator.FromHtml(TS);
                        break;
                }
            }
            else
            {
                bannerCount = 0;
                // Give UNCLASSIFIED if a group or domain does not exist
                if (string.IsNullOrEmpty(userGroup) || string.IsNullOrEmpty(domainPath))
                {
                    userRole = "UNKNOWN";
                    lbl_Classification.Text = U_TEXT;                           // Sets default clearance text
                    lbl_Classification.BackColor = ColorTranslator.FromHtml(U);
                    btnClose.BackColor = ColorTranslator.FromHtml(U);
                    btnHide.BackColor = ColorTranslator.FromHtml(U);
                    btnChange.BackColor = ColorTranslator.FromHtml(U);
                    btnAbout.BackColor = ColorTranslator.FromHtml(U);
                    lbl_Computer.BackColor = ColorTranslator.FromHtml(U);
                    lbl_User.BackColor = ColorTranslator.FromHtml(U);
                }
                else if (userGroup.Contains("OU=IT") || userGroup.Contains("OU=HR") || userGroup.Contains("OU=Secretary") || userGroup.Contains("OU=Administrator"))
                {
                    userRole = "Administrator";
                    lbl_Classification.Text = C_TEXT;
                    lbl_Classification.BackColor = ColorTranslator.FromHtml(C);
                    btnClose.BackColor = ColorTranslator.FromHtml(C);
                    btnHide.BackColor = ColorTranslator.FromHtml(C);
                    btnChange.BackColor = ColorTranslator.FromHtml(C);
                    btnAbout.BackColor = ColorTranslator.FromHtml(C);
                    lbl_Computer.BackColor = ColorTranslator.FromHtml(C);
                    lbl_User.BackColor = ColorTranslator.FromHtml(C);
                }
                else
                {
                    userRole = "TEST";
                    // Give UNCLASSIFIEDLES if nothing else applies
                    lbl_Classification.Text = ULES_TEXT;
                    lbl_Classification.BackColor = ColorTranslator.FromHtml(ULES);
                    btnClose.BackColor = ColorTranslator.FromHtml(ULES);
                    btnHide.BackColor = ColorTranslator.FromHtml(ULES);
                    btnChange.BackColor = ColorTranslator.FromHtml(ULES);
                    btnAbout.BackColor = ColorTranslator.FromHtml(ULES);
                    lbl_Computer.BackColor = ColorTranslator.FromHtml(ULES);
                    lbl_User.BackColor = ColorTranslator.FromHtml(ULES);
                }
            }
            // Load registry and store values
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HSCB");
            string encString = Harpocrates.Encrypt("HARPOCRATES", "PASSWORD");
            key.SetValue("Role", userRole);
            key.SetValue("Password", encString);
            key.Close();
        }
        #endregion

        #region Banner Structures
        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct APPBARDATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }
        #endregion

        #region Banner Enumerators
        enum ABMsg : int
        {
            ABM_NEW = 0,
            ABM_REMOVE = 1,
            ABM_QUERYPOS = 2,
            ABM_SETPOS = 3,
            ABM_GETSTATE = 4,
            ABM_GETTASKBARPOS = 5,
            ABM_ACTIVATE = 6,
            ABM_GETAUTOHIDEBAR = 7,
            ABM_SETAUTOHIDEBAR = 8,
            ABM_WINDOWPOSCHANGED = 9,
            ABM_SETSTATE = 10
        }

        enum ABNotify : int
        {
            ABN_STATECHANGE = 0,
            ABN_POSCHANGED,
            ABN_FULLSCREENAPP,
            ABN_WINDOWARRANGE
        }

        enum ABEdge : int
        {
            ABE_LEFT = 0,
            ABE_TOP,
            ABE_RIGHT,
            ABE_BOTTOM
        }
        #endregion

        #region Banner Registration Variables
        private bool fBarRegistered = false;
        [DllImport("SHELL32", CallingConvention = CallingConvention.StdCall)]
        static extern uint SHAppBarMessage(int dwMessage, ref APPBARDATA pData);
        [DllImport("USER32")]
        static extern int GetSystemMetrics(int Index);
        [DllImport("User32.dll", ExactSpelling = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool MoveWindow
            (IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int RegisterWindowMessage(string msg);
        private int uCallBack;
        #endregion

        #region Register Banner as WinApplication
        /// <summary>
        /// Register the Banner form as an application bar.
        /// Sets up the banner to mimic a start bar,
        /// moves user's accessible window content down to prevent banner from being covered.
        /// </summary>
        private void RegisterBar()
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            if (!fBarRegistered)
            {
                uCallBack = RegisterWindowMessage("AppBarMessage");
                abd.uCallbackMessage = uCallBack;

                uint ret = SHAppBarMessage((int)ABMsg.ABM_NEW, ref abd);
                fBarRegistered = true;

                ABSetPos();
            }
            else
            {
                SHAppBarMessage((int)ABMsg.ABM_REMOVE, ref abd);
                fBarRegistered = false;
            }
        }

        /// <summary>
        /// Set the position of the registered application banner.
        /// Moves window content beneath banner to prevent banner from covering content.
        /// </summary>
        private void ABSetPos()
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            abd.uEdge = (int)ABEdge.ABE_TOP;

            if (abd.uEdge == (int)ABEdge.ABE_LEFT || abd.uEdge == (int)ABEdge.ABE_RIGHT)
            {
                abd.rc.top = 0;
                abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                if (abd.uEdge == (int)ABEdge.ABE_LEFT)
                {
                    abd.rc.left = 0;
                    abd.rc.right = Size.Width;
                }
                else
                {
                    abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                    abd.rc.left = abd.rc.right - Size.Width;
                }

            }
            else
            {
                abd.rc.left = 0;
                abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                if (abd.uEdge == (int)ABEdge.ABE_TOP)
                {
                    abd.rc.top = 0;
                    abd.rc.bottom = Size.Height;
                }
                else
                {
                    abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                    abd.rc.top = abd.rc.bottom - Size.Height;
                }
            }

            // Query the system for an approved size and position. 
            SHAppBarMessage((int)ABMsg.ABM_QUERYPOS, ref abd);

            // Adjust the rectangle, depending on the edge to which the 
            // appbar is anchored. 
            switch (abd.uEdge)
            {
                case (int)ABEdge.ABE_LEFT:
                    abd.rc.right = abd.rc.left + Size.Width;
                    break;
                case (int)ABEdge.ABE_RIGHT:
                    abd.rc.left = abd.rc.right - Size.Width;
                    break;
                case (int)ABEdge.ABE_TOP:
                    abd.rc.bottom = abd.rc.top + Size.Height;
                    break;
                case (int)ABEdge.ABE_BOTTOM:
                    abd.rc.top = abd.rc.bottom - Size.Height;
                    break;
            }

            // Pass the final bounding rectangle to the system. 
            SHAppBarMessage((int)ABMsg.ABM_SETPOS, ref abd);

            // Move and size the appbar so that it conforms to the 
            // bounding rectangle passed to the system. 
            MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top,
                abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, true);
        }

        /// <summary>
        /// Registers the banenr to windows processes
        /// </summary>
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == uCallBack)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)ABNotify.ABN_POSCHANGED:
                        ABSetPos();
                        break;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Determines the banner's border styling
        /// </summary>
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= (~0x00C00000); // WS_CAPTION
                cp.Style &= (~0x00800000); // WS_BORDER
                cp.ExStyle = 0x00000080 | 0x00000008; // WS_EX_TOOLWINDOW | WS_EX_TOPMOST
                return cp;
            }
        }
        #endregion

        #region On Events
        /// <summary>
        /// On load, the banner executes RegisterBar
        /// </summary>
        private void OnLoad(object sender, System.EventArgs e)
        {
            RegisterBar();
            var domainPath = DomainManager.DomainPath;
            var userGroup = DirectorySearch.SearchForUser(Environment.UserName);
            ClassifyUser(userGroup.Path, domainPath, bannerCount);
        }

        #region Form Closing
        /// <summary>
        /// User is wanting to close the banner
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            closingFlag = 1;
            this.Close();   // Triggers form closing
        }

        /// <summary>
        /// On close, de-register the banner by properly closing out of it
        /// if and only if the closingFlag has been set and the user has a proper role and password.
        /// Else, trigger a hide.
        /// </summary>
        private void frm_ClassificationBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user is not hiding banner and making use of hide form...
            if (closingFlag == 1)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HSCB");
                if (key != null)
                {
                    // Display a dialog and request password to close out of Harpocrates
                    string promptValue = ShowPromptDialog("Password required to close Harpocrates.Banner.", "Exiting Harpocrates.Banner");
                    // Catch null to prevent Decryption from erroring out
                    if (string.IsNullOrEmpty(promptValue))
                    {
                        promptValue = "000000000000000000000000000000000000000000000";
                    }
                    string decString = Harpocrates.Decrypt(key.GetValue("Password").ToString(), promptValue);
                    // If the password and role is a match, close out of Harpocrates
                    if(decString == "HARPOCRATES" && key.GetValue("Role").ToString() == "Administrator")
                    {
                        key.Close();
                        Application.OpenForms.OfType<frm_ClassificationBanner>().FirstOrDefault().Hide();
                        RegisterBar();      // De-registers the application bar
                        closingFlag = 0;
                        Application.Exit(); // Forces program to exit with code 0, does not create dispose error
                    } else
                    {
                        hidingFlag = 1;
                        key.Close();
                    }
                }
            } else
            {
                if(hidingFlag == 1)
                {
                    btnHide.PerformClick();
                }
                Application.OpenForms.OfType<frm_ClassificationBanner>().FirstOrDefault().Hide();
                RegisterBar();      // De-registers the application bar
            }
        }

        private static string ShowPromptDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width=400, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        #endregion
        #endregion

        #region Hiding the Banner
        /// <summary>
        /// Button to control the banner's display features.
        /// When clicked, loads the hide banner and shows its message dialog.
        /// </summary>
        private void btnHide_Click(object sender, EventArgs e)
        {
            hidingFlag = 0;
            closingFlag = 0;
            this.Visible = false;
            RegisterBar();
            frm_HideClassificationBanner hideBanner = new frm_HideClassificationBanner();
        }
        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {
            var domainPath = DomainManager.DomainPath;
            var userGroup = DirectorySearch.SearchForUser(Environment.UserName);
            bannerCount = bannerCount + 1;
            ClassifyUser(userGroup.Path, domainPath, bannerCount);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<About>().Any())
            {
                Application.OpenForms.OfType<About>().First().Close();
            }
            About about = new About();
            about.Show();
        }
    }
}
