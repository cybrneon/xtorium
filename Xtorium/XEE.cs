using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtorium
{
    public partial class XEE : Form
    {
        public XEE()
        {
            InitializeComponent();
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
