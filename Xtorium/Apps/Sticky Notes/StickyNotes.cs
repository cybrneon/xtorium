using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtorium.Apps
{
    public partial class StickyNotes : Form
    {
        public StickyNotes()
        {
            InitializeComponent();

            panel2.Hide();
            panel3.Hide();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void StickyNotes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StickyNotes NotesOnScreen = new StickyNotes();
            NotesOnScreen.Show();
        }

        private void StickyNotes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
            this.BackColor = Color.White;
            textBox1.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SeaGreen;
            this.BackColor = Color.MediumSeaGreen;
            textBox1.BackColor = Color.MediumSeaGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MediumTurquoise;
            this.BackColor = Color.LightSeaGreen;
            textBox1.BackColor = Color.LightSeaGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Magenta;
            this.BackColor = Color.Orchid;
            textBox1.BackColor = Color.Orchid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gold;
            this.BackColor = Color.Khaki;
            textBox1.BackColor = Color.Khaki;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }
    }
}
