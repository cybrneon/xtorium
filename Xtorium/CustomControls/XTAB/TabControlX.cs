using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTabControl;

namespace Xtorium.CustomControls.XTAB
{
    public partial class TabControlX : UserControl
    {
        public TabControlX()
        {
            InitializeComponent();

            RibbonPanel.BackColor = Properties.Settings.Default.FavColor;
        }

        private void toolStripDropDownButton1_DropDownOpening(object sender, EventArgs e)
        {

        }

        int selected_index = -1;
        public List<ButtonX> buttonlist = new List<ButtonX> { };
        public List<TabPanelControl> tabPanelCtrlList = new List<TabPanelControl> { };

        void UpdateButtons()
        {
            if (buttonlist.Count > 0)
            {
                for (int i = 0; i < buttonlist.Count; i++)
                {
                    if (i == selected_index)
                    {
                        buttonlist[i].ChangeColorMouseHC = false;
                        buttonlist[i].BXBackColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].ForeColor = Color.White;
                        buttonlist[i].MouseHoverColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].MouseClickColor1 = Color.FromArgb(20, 120, 240);
                    }
                    else
                    {
                        buttonlist[i].ChangeColorMouseHC = true;
                        buttonlist[i].ForeColor = Color.White;
                        buttonlist[i].MouseHoverColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].BXBackColor = Color.FromArgb(40, 40, 40);
                        buttonlist[i].MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    }
                }
            }
        }

        void createAndAddButton(string tabtext, TabPanelControl tpcontrol, Point loc)
        {
            ButtonX bx = new ButtonX();
            bx.DisplayText = tabtext;
            bx.Text = tabtext;
            bx.Size = new Size(130, 30);
            bx.Location = loc;
            bx.ForeColor = Color.White;
            bx.BXBackColor = Color.FromArgb(20, 120, 240);
            bx.MouseHoverColor = Color.FromArgb(20, 120, 240);
            bx.MouseClickColor1 = Color.FromArgb(20, 80, 200);
            bx.ChangeColorMouseHC = false;
            bx.TextLocation_X = 10;
            bx.TextLocation_Y = 9;
            bx.Font = this.Font;
            bx.Click += button_Click;
            TabButtonPanel.Controls.Add(bx);
            buttonlist.Add(bx);
            selected_index++;

            tabPanelCtrlList.Add(tpcontrol);
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tpcontrol);

            UpdateButtons();
        }

        void button_Click(object sender, EventArgs e)
        {
            string btext = ((ButtonX)sender).Text;
            int index = 0, i;
            for (i = 0; i < buttonlist.Count; i++)
            {
                if (buttonlist[i].Text == btext)
                {
                    index = i;
                }
            }
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tabPanelCtrlList[index]);
            selected_index = ((ButtonX)sender).TabIndex;

            UpdateButtons();
        }

        public void AddTab(string tabtext, TabPanelControl tpcontrol)
        {
            if (!buttonlist.Any())
            {
                createAndAddButton(tabtext, tpcontrol, new Point(0, 0));
            }
            else
            {
                createAndAddButton(tabtext, tpcontrol,
                new Point(buttonlist[buttonlist.Count - 1].Size.Width +
                buttonlist[buttonlist.Count - 1].Location.X, 0));
            }
        }

        private void toolStripButton1_DropDownOpening(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            int mergeindex = 0;
            for (int i = 0; i < buttonlist.Count; i++)
            {
                ToolStripMenuItem tbr = new ToolStripMenuItem();
                tbr.Text = buttonlist[i].Text;
                tbr.MergeIndex = mergeindex;
                if (selected_index == i)
                {
                    tbr.Checked = true;
                }
                tbr.Click += tbr_Click;
                toolStripDropDownButton1.DropDownItems.Add(tbr);
                mergeindex++;
            }
        }

        List<string> btstrlist = new List<string> { };
        void BackToFront_SelButton()
        {
            int i = 0;

            TabButtonPanel.Controls.Clear();
            btstrlist.Clear();
            for (i = 0; i < buttonlist.Count; i++)
            {
                btstrlist.Add(buttonlist[i].Text);
            }

            buttonlist.Clear();

            for (int j = 0; j < btstrlist.Count; j++)
            {
                if (j == 0)
                {
                    ButtonX bx = new ButtonX();
                    bx.DisplayText = btstrlist[j];
                    bx.Text = btstrlist[j];
                    bx.Size = new Size(130, 30);
                    bx.Location = new Point(0, 0);
                    bx.ForeColor = Color.White;
                    bx.BXBackColor = Color.FromArgb(20, 120, 240);
                    bx.MouseHoverColor = Color.FromArgb(20, 120, 240);
                    bx.MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    bx.ChangeColorMouseHC = false;
                    bx.TextLocation_X = 10;
                    bx.TextLocation_Y = 9;
                    bx.Font = this.Font;
                    bx.Click += button_Click;
                    TabButtonPanel.Controls.Add(bx);
                    buttonlist.Add(bx);
                    selected_index++;
                }
                else if (j > 0)
                {
                    ButtonX bx = new ButtonX();
                    bx.DisplayText = btstrlist[j];
                    bx.Text = btstrlist[j];
                    bx.Size = new Size(130, 30);
                    bx.ForeColor = Color.White;
                    bx.BXBackColor = Color.FromArgb(20, 120, 240);
                    bx.MouseHoverColor = Color.FromArgb(20, 120, 240);
                    bx.MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    bx.ChangeColorMouseHC = false;
                    bx.TextLocation_X = 10;
                    bx.TextLocation_Y = 9;
                    bx.Font = this.Font;
                    bx.Click += button_Click;
                    bx.Location = new Point(buttonlist[j - 1].Size.Width +
                                  buttonlist[j - 1].Location.X, 0);
                    TabButtonPanel.Controls.Add(bx);
                    buttonlist.Add(bx);
                    selected_index++;
                }
            }
            TabPanel.Controls.Clear();
        }

        void tbr_Click(object sender, EventArgs e)
        {
            int i;
            for (int k = 0; k < ((ToolStripMenuItem)sender).MergeIndex; k++)
            {
                int j = 0;
                for (i = ((ToolStripMenuItem)sender).MergeIndex; i >= 0; i--)
                {
                    ButtonX but = buttonlist[i];
                    ButtonX temp = buttonlist[j];
                    buttonlist[i] = temp;
                    buttonlist[j] = but;

                    TabPanelControl uct1 = tabPanelCtrlList[i];
                    TabPanelControl tempusr = tabPanelCtrlList[j];
                    tabPanelCtrlList[i] = tempusr;
                    tabPanelCtrlList[j] = uct1;
                }
            }

            string btext = ((ToolStripMenuItem)sender).Text;
            BackToFront_SelButton();
            selected_index = 0;
            TabPanel.Controls.Add(tabPanelCtrlList[buttonlist[0].TabIndex]);
            UpdateButtons();
        }

        public void RemoveTab(int index)
        {
            if (index >= 0 && buttonlist.Count > 0 && index < buttonlist.Count)
            {
                buttonlist.RemoveAt(index);
                tabPanelCtrlList.RemoveAt(index);
                BackToFront_SelButton();
                if (buttonlist.Count > 1)
                {
                    if (index - 1 >= 0)
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[index - 1]);
                    }
                    else
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[(index - 1) + 1]);
                        selected_index = (index - 1) + 1;
                    }
                }
                selected_index = index - 1;

                if (buttonlist.Count == 1)
                {
                    TabPanel.Controls.Add(tabPanelCtrlList[0]);
                    selected_index = 0;
                }
            }
            UpdateButtons();
        }
    }
}
