using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Xtorium
{
    public partial class UserAccountSettings : UserControl
    {
        public UserAccountSettings()
        {
            InitializeComponent();

            FileStream fs = new FileStream(@"User/profile.jpg", FileMode.Open, FileAccess.Read);
            pictureBox1.BackgroundImage = System.Drawing.Image.FromStream(fs);
            fs.Close();

            //The code here is for a round picture box in the Xtorium ID System. Not finished yet. So deploy when complete.
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.Region = new Region(path);

            textBox1.Text = Properties.Settings.Default.NameID;
            textBox1.ForeColor = Properties.Settings.Default.FavColor;
            textBox2.Text = Properties.Settings.Default.emailAdress;
            textBox2.ForeColor = Properties.Settings.Default.FavColor;
            pictureBox1.BackColor = Properties.Settings.Default.FavColor;
            linkLabel1.ForeColor = Properties.Settings.Default.FavColor;
            linkLabel2.ForeColor = Properties.Settings.Default.FavColor;
            if (Properties.Settings.Default.IDShowInMenu == true)
            {
                checkBox1.CheckState = CheckState.Checked;
            }

            if (Properties.Settings.Default.FeedEnabled == true)
            {
                checkBox2.CheckState = CheckState.Checked;
            }

            ConfirmationLabel.Visible = false;
            ConfirmationPanel.Visible = false;

            if (Properties.Settings.Default.ThemeWorB == "White")
            {
                this.BackColor = Color.White;
                button2.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(55, 53, 54);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;

            }

            if (Properties.Settings.Default.ThemeWorB == "Dark")
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.FromArgb(55, 53, 54);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                textBox1.BackColor = Color.FromArgb(33, 33, 33);
                textBox2.BackColor = Color.FromArgb(33, 33, 33);
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NameID = textBox1.Text;
            Properties.Settings.Default.emailAdress = textBox2.Text;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.IDShowInMenu = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                Properties.Settings.Default.IDShowInMenu = false;
            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.FeedEnabled = true;
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                Properties.Settings.Default.FeedEnabled = false;
            }

            SaveProfilePicture();
            Properties.Settings.Default.Save();

            ConfirmationPanel.Visible = true;
            ConfirmationLabel.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image File;

            OpenFileDialog OpenImage = new OpenFileDialog();
            OpenImage.Filter = "JPG image(*jpg)|*.jpg*, PNG image(*png)|*.png*";

            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(OpenImage.FileName);
                pictureBox1.BackgroundImage = File;
            }

            else
            {
                MessageBox.Show("An error occured while getting your image, please try again with a new one.", "Error - Xtorium ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void SaveProfilePicture()
        {
            Bitmap bmp = new Bitmap(pictureBox1.BackgroundImage);

            if (System.IO.File.Exists(@"User/profile.jpg"))
            {
                System.IO.File.Delete(@"User/profile.jpg");

            }
            bmp.Save(@"User/profile.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
        }

        private void UserAccountSettings_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.profile;

            Bitmap bmp = new Bitmap(pictureBox1.BackgroundImage);

            if (System.IO.File.Exists(@"User/profile.jpg"))
            {
                System.IO.File.Delete(@"User/profile.jpg");

            }
            bmp.Save(@"User/profile.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
        }
    }
}
