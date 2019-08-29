using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtorium.Account
{
    public partial class UserAccountSettingsBOX : Form
    {
        public UserAccountSettingsBOX()
        {
            InitializeComponent();

            panel1.Controls.Clear();
            UserAccountSettings UserAccoutS = new UserAccountSettings();
            panel1.Controls.Add(UserAccoutS);
            panel1.Dock = DockStyle.Fill;

        }

        private void UserAccountSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
