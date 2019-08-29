using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Globalization;
using Xtorium.Apps;
using Xtorium.Apps.Clock;
using Xtorium.Account;
using System.Net.NetworkInformation;

namespace Xtorium
{
    public partial class MainWindow : Form
    {
        public static String favXml = "favorites.xml", linksXml = "links.xml";
        String settingsXml = "settings.xml", historyXml = "history.xml";
        List<String> urls = new List<String>();
        CultureInfo currentCulture;


        

        public MainWindow()
        {
            InitializeComponent();

            XIDUserToolStripMenuItem.Text = Properties.Settings.Default.NameID;
            search_button.BackColor = Properties.Settings.Default.FavColor;

            //The code here is for a round picture box in the Xtorium ID System. Not finished yet. So deploy when complete.
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(0, 0, id_profilePicture.Width, id_profilePicture.Height);
            //id_profilePicture.Region = new Region(path);

            HUBpanel.Visible = false;
            FindPanel.Visible = false;


            if ((bool)Properties.Settings.Default["IDShowInMenu"] == true)
            {
                XIDUserToolStripMenuItem.Visible = true;
                toolStripSeparator12.Visible = true;

                XIDUserToolStripMenuItem.BackColor = Properties.Settings.Default.FavColor;
            }

            else if ((bool)Properties.Settings.Default["IDShowInMenu"] == false)
            {
                XIDUserToolStripMenuItem.Visible = false;
                toolStripSeparator12.Visible = false;
            }

            pictureBox3.BackColor = Properties.Settings.Default.FavColor;


        }

        ChromiumWebBrowser XENGINE;
        
        private ImageList myimg = new ImageList();
        int i = 1;

        

        public Bitmap CloseImage { get; private set; }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Welcome page only for FIRST LAUNCH of Xtorium
            if ((bool)Properties.Settings.Default["FirstTimeRun"] == true)
            {

                Welcome FirstTimeWelcome = new Welcome();
                FirstTimeWelcome.ShowDialog();
                Properties.Settings.Default["FirstTimeRun"] = false;
                Properties.Settings.Default.Save();
            }

            CefSettings XESettings = new CefSettings();
            //Initialize
            Cef.Initialize(XESettings);
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser(Properties.Settings.Default.Home);
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            URLtxt.Text = "about:blank";
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;

            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.InitialLocation;
                Point il = new Point(0, 0);
                Size sz = Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                Size = sz;
                Location = il;
            }

            FileStream fs = new FileStream(@"User/profile.jpg", FileMode.Open, FileAccess.Read);
            id_profilePicture.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();

            XENGINE.DownloadHandler = new DownloadHandler();

        }

        private void XENGINE_LoadError(object sender, LoadErrorEventArgs e)
        {
            //Type error code here "error_page.html" from /Storage
        }

        public void XENGINE_TitleChanged(object sender, AddressChangedEventArgs e)
        {
            
        }

        private void XENGINE_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                URLtxt.Text = e.Address;
            }));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser(Properties.Settings.Default.Home);
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            URLtxt.Text = "about:blank";
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;
        }

        private void XENGINE_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tabControl.SelectedTab.Text = e.Title;
            }));


        }

        private void URLtxt_KeyDown(object sender, KeyEventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)

                    if(e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    XENGINE.Load(URLtxt.Text);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                if (XENGINE.CanGoBack)
            {
                XENGINE.Back();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                if (XENGINE.CanGoForward)
            {
                XENGINE.Forward();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count - 1 > 0)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Load(Properties.Settings.Default.HomeButton);
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            
                if (Properties.Settings.Default.DefaultSearchEngine == "Bing")
                {
                    ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    if (XENGINE != null)
                        XENGINE.Load("https://www.bing.com/search?q=" + SearchBOX.Text.Replace(" ", "+"));
                }

                if (Properties.Settings.Default.DefaultSearchEngine == "Google")
                {
                    ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    if (XENGINE != null)
                        XENGINE.Load("https://www.google.com/search?q=" + SearchBOX.Text.Replace(" ", "+"));
                }

                if (Properties.Settings.Default.DefaultSearchEngine == "DuckDuckGo")
                {
                    ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    if (XENGINE != null)
                        XENGINE.Load("https://www.duckduckgo.com/?q=" + SearchBOX.Text.Replace(" ", "+"));
                }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (Properties.Settings.Default.DefaultSearchEngine == "Bing")
                {
                    ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    if (XENGINE != null)
                        XENGINE.Load("http://www.bing.com/search?q=" + SearchBOX.Text.Replace(" ", "+"));
                }

                if (Properties.Settings.Default.DefaultSearchEngine == "Google")
                {
                    ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    if (XENGINE != null)
                        XENGINE.Load("http://www.google.com/search?q=" + SearchBOX.Text.Replace(" ", "+"));
                }
            }
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                var iconURL = "http://www.google.com/s2/favicons?domain=" + XENGINE;
                WebRequest request = HttpWebRequest.Create(iconURL);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                dynamic favicon = Image.FromStream(stream);
                string i = Convert.ToString(myimg.Images.Count);
                myimg.Images.Add(i, favicon);
                tabControl.ImageList = myimg;
                tabControl.SelectedTab.ImageIndex = myimg.Images.Count - 1;
            }
        }

        private void developerToolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.ShowDevTools();
        }

        private void newTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser(Properties.Settings.Default.Home);
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            URLtxt.Text = "New Tab";
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;
        }

        private void removeTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count - 1 > 0)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void newWindowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainWindow XtoriumWindow = new MainWindow();
            XtoriumWindow.Show();
        }

        private void fullScreenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Full_Screen();
        }

        private void Full_Screen()
        {
            if (!(this.FormBorderStyle == FormBorderStyle.None && this.WindowState == FormWindowState.Maximized))
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.TopMost = false;
            }
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Load(Properties.Settings.Default.Home);
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Copy();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Cut();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Paste();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.SelectAll();
        }

        private void savePageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void printPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.Print();
        }

        private void viewWebsiteSourceCodeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (XENGINE != null)
                XENGINE.ViewSource();
        }

        private void hubToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HUBpanel.Show();


            label2.Text = Properties.Settings.Default.NameID;
            label4.Text = Properties.Settings.Default.emailAdress;
            button1.ForeColor = Properties.Settings.Default.FavColor;
            panel4.BackColor = Properties.Settings.Default.FavColor;
            panel5.BackColor = Properties.Settings.Default.FavColor;
            panel8.BackColor = Properties.Settings.Default.FavColor;
            this.HUBtabControl.SelectTab(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HUBpanel.Hide();
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUBpanel.Show();
            button1.ForeColor = Properties.Settings.Default.FavColor;
            panel4.BackColor = Properties.Settings.Default.FavColor;
            this.HUBtabControl.SelectTab(1);
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            HUBpanel.Show();
            button1.ForeColor = Properties.Settings.Default.FavColor;
            panel4.BackColor = Properties.Settings.Default.FavColor;
            this.HUBtabControl.SelectTab(2);
        }

        private void runCMDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            XSettingsUserControl XS = new XSettingsUserControl();
            XS.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(XS);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "Xtorium Settings";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            XSettingsUserControl XS = new XSettingsUserControl();
            XS.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(XS);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "Xtorium Settings";
        }

        private void aboutWebSurfXtoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutSettings AboutX = new AboutSettings();
            AboutX.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(AboutX);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "About Xtorium";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteHistory DeleteH = new DeleteHistory();
            if (DeleteH.ShowDialog() == DialogResult.OK)
            {
                if (DeleteH.history.Checked == true)
                {
                    File.Delete(historyXml);
                    historyTreeView.Nodes.Clear();
                }
                if (DeleteH.tempFiles.Checked == true)
                {
                    urls.Clear();
                    while (imgList.Images.Count > 4)
                        imgList.Images.RemoveAt(imgList.Images.Count - 1);
                    File.Delete("source.txt");

                }
            }
        }

        private void stickyNotesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StickyNotes NotesOnScreen = new StickyNotes();
            NotesOnScreen.Show();

            HUBpanel.Visible = false;

        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Application.ExitThread();
            Application.Exit();
        }

        private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileExplorer Explorer = new FileExplorer();
            Explorer.Show();

            HUBpanel.Visible = false;
        }

        private void downloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Downloads";
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser(@".\Storage\downloads.htm");
            XENGINE.Parent = tab;
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            string curDir = Directory.GetCurrentDirectory();
            XENGINE.Dock = DockStyle.Fill;
            URLtxt.Text = "xtorium://downloads";

        }

        private void clockToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            ClockApp Clock = new ClockApp();
            Clock.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(Clock);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "Clock";

            HUBpanel.Visible = false;
        }

        private void dEVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aOXWindowTestPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddFavorite AddFav = new AddFavorite();
            AddFav.Show();
        }


        string adress, name;


        //add link to favorites
        private void addLink(String url, string name)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("link");
            el.SetAttribute("url", url);
            el.InnerText = name;

            if (!File.Exists(linksXml))
            {
                XmlElement root = myXml.CreateElement("links");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load(linksXml);
                myXml.DocumentElement.AppendChild(el);
            }

            if (HUBpanel.Visible == true)
            {
                TreeNode node = new TreeNode(el.InnerText, faviconIndex(url), faviconIndex(el.GetAttribute("url")));
                node.Name = el.GetAttribute("url");
                node.ToolTipText = el.GetAttribute("url");
                node.ContextMenuStrip = linkContextMenu;
                favoritesTreeView.Nodes[0].Nodes.Add(node);
            }
            myXml.Save(linksXml);
        }

        //delete link method
        private void deleteLink()
        {
            if (HUBpanel.Visible == true)
                favoritesTreeView.Nodes[0].Nodes[adress].Remove();
            XmlDocument myXml = new XmlDocument();
            myXml.Load(linksXml);
            XmlElement root = myXml.DocumentElement;
            foreach (XmlElement x in root.ChildNodes)
            {
                if (x.GetAttribute("url").Equals(adress))
                {
                    root.RemoveChild(x);
                    break;
                }
            }

            myXml.Save(linksXml);
        }

        //renameLink method
        private void renameLink()
        {
            RenameLink rl = new RenameLink(name);
            if (rl.ShowDialog() == DialogResult.OK)
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load(linksXml);
                foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
                {
                    if (x.InnerText.Equals(name))
                    {
                        x.InnerText = rl.newName.Text;
                        break;
                    }
                }
                if (HUBpanel.Visible == true)
                    favoritesTreeView.Nodes[0].Nodes[adress].Text = rl.newName.Text;
                myXml.Save(linksXml);
            }
            rl.Close();
        }

        //delete favorite method
        private void deleteFavorit()
        {
            favoritesTreeView.SelectedNode.Remove();

            XmlDocument myXml = new XmlDocument();
            myXml.Load(favXml);
            XmlElement root = myXml.DocumentElement;
            foreach (XmlElement x in root.ChildNodes)
            {
                if (x.GetAttribute("url").Equals(adress))
                {
                    root.RemoveChild(x);
                    break;
                }
            }

            myXml.Save(favXml);

        }

        //renameFavorit method
        private void renameFavorit()
        {
            RenameLink rl = new RenameLink(name);
            if (rl.ShowDialog() == DialogResult.OK)
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load(favXml);
                foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
                {
                    if (x.InnerText.Equals(name))
                    {
                        x.InnerText = rl.newName.Text;
                        break;
                    }
                }
                favoritesTreeView.Nodes[adress].Text = rl.newName.Text;
                myXml.Save(favXml);
            }
            rl.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Spotify";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser("https://play.spotify.com/");
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;

            HUBpanel.Visible = false;

        }

        private void label10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
            File.Delete("source.txt");
        }

        // favicon
        public static Image favicon(String u, string file)
        {
            Uri url = new Uri(u);
            String iconurl = "http://" + url.Host + "/favicon.ico";

            WebRequest request = WebRequest.Create(iconurl);
            try
            {
                WebResponse response = request.GetResponse();

                Stream s = response.GetResponseStream();
                return Image.FromStream(s);
            }
            catch (Exception ex)
            {
                return Image.FromFile(file);
            }


        }

        //favicon index
        private int faviconIndex(string url)
        {
            Uri key = new Uri(url);
            if (!imgList.Images.ContainsKey(key.Host.ToString()))
                imgList.Images.Add(key.Host.ToString(), favicon(url, "link.png"));
            return imgList.Images.IndexOfKey(key.Host.ToString());
        }

        //addFavorite method
        private void addFavorite(String url, string name)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("favorite");
            el.SetAttribute("url", url);
            el.InnerText = name;
            if (!File.Exists(favXml))
            {
                XmlElement root = myXml.CreateElement("favorites");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load(favXml);
                myXml.DocumentElement.AppendChild(el);
            }
            if (HUBpanel.Visible == true)
            {
                TreeNode node = new TreeNode(el.InnerText, faviconIndex(el.GetAttribute("url")), faviconIndex(el.GetAttribute("url")));
                node.ToolTipText = el.GetAttribute("url");
                node.Name = el.GetAttribute("url");
                node.ContextMenuStrip = favoritesContextMenu;
                favoritesTreeView.Nodes.Add(node);
            }
            myXml.Save(favXml);
        }

        private void showHistory()
        {
            historyTreeView.Nodes.Clear();
            XmlDocument myXml = new XmlDocument();

            if (File.Exists(historyXml))
            {
                myXml.Load(historyXml);
                DateTime now = DateTime.Now;
                if (comboBox2.Text.Equals("Ordered Visited Today"))
                {
                    historyTreeView.ShowRootLines = false;
                    foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                    {
                        DateTime d = DateTime.Parse(el.GetAttribute("lastVisited"), currentCulture);

                        if (!(d.Date == now.Date)) return;

                        TreeNode node =
                            new TreeNode(el.GetAttribute("url"), 3, 3);
                        node.ToolTipText = el.GetAttribute("url") + "\nLast Visited: " + el.GetAttribute("lastVisited") + "\nTimes Visited: " + el.GetAttribute("times");
                        node.Name = el.GetAttribute("url");
                        node.ContextMenuStrip = histContextMenuStrip;
                        historyTreeView.Nodes.Add(node);
                    }

                }

                if (comboBox2.Text.Equals("View By Site"))
                {
                    historyTreeView.ShowRootLines = true;
                    foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                    {
                        Uri site = new Uri(el.GetAttribute("url"));

                        if (!historyTreeView.Nodes.ContainsKey(site.Host.ToString()))
                            historyTreeView.Nodes.Add(site.Host.ToString(), site.Host.ToString(), 0, 0);
                        TreeNode node = new TreeNode(el.GetAttribute("url"), 3, 3);
                        node.ToolTipText = el.GetAttribute("url") + "\nLast Visited: " + el.GetAttribute("lastVisited") + "\nTimes Visited: " + el.GetAttribute("times");
                        node.Name = el.GetAttribute("url");
                        node.ContextMenuStrip = histContextMenuStrip;
                        historyTreeView.Nodes[site.Host.ToString()].Nodes.Add(node);
                    }
                }

                if (comboBox2.Text.Equals("View by Date"))
                {
                    historyTreeView.ShowRootLines = true;
                    historyTreeView.Nodes.Add("2 Weeks Ago", "2 Weeks Ago", 2, 2);
                    historyTreeView.Nodes.Add("Last Week", "Last Week", 2, 2);
                    historyTreeView.Nodes.Add("This Week", "This Week", 2, 2);
                    historyTreeView.Nodes.Add("Yesterday", "Yesterday", 2, 2);
                    historyTreeView.Nodes.Add("Today", "Today", 2, 2);
                    foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                    {
                        DateTime d = DateTime.Parse(el.GetAttribute("lastVisited"), currentCulture);

                        TreeNode node = new TreeNode(el.GetAttribute("url"), 3, 3);
                        node.ToolTipText = el.GetAttribute("url") + "\nLast Visited: " + el.GetAttribute("lastVisited") + "\nTimes Visited: " + el.GetAttribute("times");
                        node.Name = el.GetAttribute("url");
                        node.ContextMenuStrip = histContextMenuStrip;

                        if (d.Date == now.Date)
                            historyTreeView.Nodes[4].Nodes.Add(node);
                        else
                            if (d.AddDays(1).ToShortDateString().Equals(now.ToShortDateString()))
                            historyTreeView.Nodes[3].Nodes.Add(node);
                        else
                                if (d.AddDays(7) > now)
                            historyTreeView.Nodes[2].Nodes.Add(node);
                        else
                                    if (d.AddDays(14) > now)
                            historyTreeView.Nodes[1].Nodes.Add(node);
                        else
                                        if (d.AddDays(21) > now)
                            historyTreeView.Nodes[0].Nodes.Add(node);
                        else
                                            if (d.AddDays(22) > now)
                            myXml.DocumentElement.RemoveChild(el);
                    }

                }
            }
        }

        private void HUBpanel_VisibleChanged(object sender, EventArgs e)
        {
            if (HUBpanel.Visible == true)
            {
                showFavorites();
                showHistory();
            }
            else
            {
                favoritesTreeView.Nodes.Clear();
                historyTreeView.Nodes.Clear();
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            showHistory();
        }

        private void restartXtoriumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Note10_X Note10 = new Note10_X();
            Note10.Show();

            HUBpanel.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            (new OrganizeFav(favoritesTreeView, linkContextMenu, favoritesContextMenu)).ShowDialog();
        }

        private void URLtxt_Click(object sender, EventArgs e)
        {
            URLtxt.SelectAll();
        }

        private void checkIfOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HUBpanel.Show();
            label2.Text = Properties.Settings.Default.NameID;
            label4.Text = Properties.Settings.Default.emailAdress;
            button1.ForeColor = Properties.Settings.Default.FavColor;
            panel4.BackColor = Properties.Settings.Default.FavColor;
            panel5.BackColor = Properties.Settings.Default.FavColor;
            panel8.BackColor = Properties.Settings.Default.FavColor;
            this.HUBtabControl.SelectTab(0);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            XSettingsUserControl XS = new XSettingsUserControl();
            XS.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(XS);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "Xtorium Settings";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Application.ExitThread();
            Application.Exit();
        }

        private void experimentsLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExperimentsLauncher ExpLauncher = new ExperimentsLauncher();
            ExpLauncher.Show();
        }

        private void newSettingsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XSettingsUserControl XS = new XSettingsUserControl();
            XS.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(XS);
            tabControl.TabPages.Add(myTabPage);
            tabControl.SelectTab(tabControl.TabCount - 1);
            myTabPage.Text = "Xtorium Settings (Beta)";
        }

        private void launchXtoriumMiniEXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 Form11NEWTAB = new Form11();
            Form11NEWTAB.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adamclouderWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void XtoriumWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Xtorium Website";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser("https://adamclouder.weebly.com/");
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            DeleteHistory DeleteH = new DeleteHistory();
            if (DeleteH.ShowDialog() == DialogResult.OK)
            {
                if (DeleteH.history.Checked == true)
                {
                    File.Delete(historyXml);
                    historyTreeView.Nodes.Clear();
                }
                if (DeleteH.tempFiles.Checked == true)
                {
                    urls.Clear();
                    while (imgList.Images.Count > 4)
                        imgList.Images.RemoveAt(imgList.Images.Count - 1);
                    File.Delete("source.txt");

                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPanel.Show();
            txtFind.Focus();
            txtFind.SelectAll();
        }

        private void CloseFind_Click(object sender, EventArgs e)
        {
            FindPanel.Visible = false;
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            XENGINE.StopFinding(true);
        }

        string lastSearch = "";

        private void nextFind_Click(object sender, EventArgs e)
        {
            FindTextOnPage(true);
        }

        private void FindTextOnPage(bool next = true)
            {
            bool first = lastSearch != txtFind.Text;
            ChromiumWebBrowser XENGINE = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                if (lastSearch=="")
                {
                    XENGINE.GetBrowser().Find(0, lastSearch, true, false, !first);
                }
                else
                {
                    XENGINE.GetBrowser().StopFinding(true);
                }
                txtFind.Focus();
            }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FindTextOnPage(true);
        }

        private void prevFind_Click(object sender, EventArgs e)
        {
            FindTextOnPage(false);
        }

        private void XIDUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FeedEnabled == true)
            {
                UserAccount UserAccountFeed = new UserAccount();
                UserAccountFeed.Show();
            }
            else if (Properties.Settings.Default.FeedEnabled == false)
            {
                UserAccountMin UserAccount = new UserAccountMin();
                UserAccount.Show();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Telegram";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser XENGINE = new ChromiumWebBrowser("https://web.telegram.org");
            XENGINE.Parent = tab;
            XENGINE.Dock = DockStyle.Fill;
            XENGINE.AddressChanged += XENGINE_AddressChanged;
            XENGINE.TitleChanged += XENGINE_TitleChanged;

            HUBpanel.Visible = false;
        }

        private void helpCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpCenter HELPC = new HelpCenter();
            HELPC.Show();
        }

        private void deleteHistory()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(historyXml);
            XmlElement root = myXml.DocumentElement;
            foreach (XmlElement x in root.ChildNodes)
            {
                if (x.GetAttribute("url").Equals(URLtxt))
                {
                    root.RemoveChild(x);
                    break;
                }
            }
            historyTreeView.SelectedNode.Remove();
            myXml.Save(historyXml);
        }

        private void showFavorites()
        {
            XmlDocument myXml = new XmlDocument();
            TreeNode link = new TreeNode("Links", 0, 0);
            link.NodeFont = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            favoritesTreeView.Nodes.Add(link);

            if (File.Exists(favXml))
            {
                myXml.Load(favXml);

                foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                {
                    TreeNode node =
                        new TreeNode(el.InnerText, faviconIndex(el.GetAttribute("url")), faviconIndex(el.GetAttribute("url")));
                    node.ToolTipText = el.GetAttribute("url");
                    node.Name = el.GetAttribute("url");
                    node.ContextMenuStrip = favoritesContextMenu;
                    favoritesTreeView.Nodes.Add(node);
                }

            }

            if (File.Exists(linksXml))
            {
                myXml.Load(linksXml);

                foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                {
                    TreeNode node =
                        new TreeNode(el.InnerText, faviconIndex(el.GetAttribute("url")), faviconIndex(el.GetAttribute("url")));
                    node.ToolTipText = el.GetAttribute("url");
                    node.Name = el.GetAttribute("url");
                    node.ContextMenuStrip = linkContextMenu;
                    favoritesTreeView.Nodes[0].Nodes.Add(node);
                }

            }

        }
    }
}
