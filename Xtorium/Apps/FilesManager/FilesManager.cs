using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtorium.Apps.FileXplorer;
using Xtorium.Account;

namespace Xtorium
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();

            panel_color.BackColor = Properties.Settings.Default.FavColor;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                Menu1.BackColor = Color.FromArgb(246, 246, 246);
                ContentPanel.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.FromArgb(246, 246, 246);
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(246, 246, 246);
                button6.ForeColor = Color.Black;
                button6.BackColor = Color.FromArgb(246, 246, 246);
                button4.ForeColor = Color.Black;
                button4.BackColor = Color.FromArgb(246, 246, 246);
            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                menuStrip1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                Menu1.BackColor = Color.FromArgb(54, 54, 54);
                ContentPanel.BackColor = Color.FromArgb(33, 33, 33);
                button1.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(55, 53, 54);
                button2.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(55, 53, 54);
                button6.ForeColor = Color.White;
                button6.BackColor = Color.FromArgb(55, 53, 54);
                button4.ForeColor = Color.White;
                button4.BackColor = Color.FromArgb(55, 53, 54);
            }
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFX About = new AboutFX();
            About.Show();
        }

        private void openNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileExplorer FEX = new FileExplorer();
            FEX.Show();
        }

        private void xtoriumIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountMin ID = new UserAccountMin();
            ID.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
