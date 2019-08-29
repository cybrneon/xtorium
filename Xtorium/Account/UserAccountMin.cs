using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtorium.Apps;

namespace Xtorium.Account
{
    public partial class UserAccountMin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;


        }



        public UserAccountMin()
        {
            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            //The code here is for a round picture box in the Xtorium ID System. Not finished yet. So deploy when complete.
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            //pictureBox2.Region = new Region(path);

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                button2.BackgroundImage = Properties.Resources.Settings_black;
                button1.BackgroundImage = Properties.Resources.close_sign_104px;
                menu_button.BackgroundImage = Properties.Resources.Menu_black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                //xtoriumGradientPanel1.BackColor = Properties.Settings.Default.FavColor;
            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                button2.BackgroundImage = Properties.Resources.Settings_white;
                button1.BackgroundImage = Properties.Resources.close_sign_104pxW;
                menu_button.BackgroundImage = Properties.Resources.Menu_white;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                //xtoriumGradientPanel1.BackColor = Properties.Settings.Default.FavColor;
            }

            FileStream fs = new FileStream(@"User/profile.jpg", FileMode.Open, FileAccess.Read);
            pictureBox2.BackgroundImage = System.Drawing.Image.FromStream(fs);
            fs.Close();

            pictureBox2.BackColor = Properties.Settings.Default.FavColor;
            label2.Text = Properties.Settings.Default.NameID;
            label3.Text = Properties.Settings.Default.emailAdress;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserAccountSettingsBOX Settings = new UserAccountSettingsBOX();
            Settings.Show();
        }
    }
}
