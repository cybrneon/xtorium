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

namespace Xtorium
{
    public partial class Note10_X : Form
    {

        public Note10_X()
        {
            InitializeComponent();
        }

        private void aboutFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutNote10 About = new AboutNote10();
            About.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult cl = MessageBox.Show("Do you want to save changes in the current file?", "Note10", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cl == DialogResult.Yes)
                {
                    
                }
            }
        }
    }
}
