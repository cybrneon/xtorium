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

namespace Xtorium
{
    public partial class Welcome : Form
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



        public Welcome()
        {
            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();

            //The code here is for a round picture box in the Xtorium ID System. Not finished yet. So deploy when complete.
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            //pictureBox2.Region = new Region(path);

            FileStream fs = new FileStream(@"User/profile.jpg", FileMode.Open, FileAccess.Read);
            pictureBox2.BackgroundImage = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NameID = textBox1.Text;
            SaveProfilePicture();
            Properties.Settings.Default.Save();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void SaveProfilePicture()
        {
            Bitmap bmp = new Bitmap(pictureBox2.BackgroundImage);

            if (System.IO.File.Exists(@"User/profile.jpg"))
            {
                System.IO.File.Delete(@"User/profile.jpg");

            }
            bmp.Save(@"User/profile.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image File;

            OpenFileDialog OpenImage = new OpenFileDialog();
            OpenImage.Filter = "JPG file(*jpg)|*.jpg*";

            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(OpenImage.FileName);
                pictureBox2.BackgroundImage = File;
            }

            else
            {
                MessageBox.Show("An error occured while getting your image, please try again with a new one.", "Error - Xtorium ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
