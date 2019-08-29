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
using System.Xml;

namespace Xtorium
{
    public partial class OrganizeFav : Form
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



        TreeView tree;
        String favXml = MainWindow.favXml, linksXml = MainWindow.linksXml;
        ContextMenuStrip linkContext, favContext;

        private void OrganizeFav_Load(object sender, EventArgs e)
        {
            ORGANIZEfavoritesTreeView.ImageList = tree.ImageList;
            ORGANIZEfavoritesTreeView.Nodes[0].ImageIndex = 0;

            XmlDocument myXml = new XmlDocument();

            if (File.Exists(favXml))
            {
                myXml.Load(favXml);

                foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                {
                    Uri url = new Uri(el.GetAttribute("url"));
                    TreeNode node = new TreeNode(el.InnerText, tree.ImageList.Images.IndexOfKey(url.Host.ToString()), tree.ImageList.Images.IndexOfKey(url.Host.ToString()));
                    node.ToolTipText = el.GetAttribute("url");
                    node.Name = el.GetAttribute("url");
                    node.ContextMenuStrip = ORGANIZEfavoritesContextMenu;
                    ORGANIZEfavoritesTreeView.Nodes.Add(node);
                }

            }

            if (File.Exists(linksXml))
            {
                myXml.Load(linksXml);

                foreach (XmlElement el in myXml.DocumentElement.ChildNodes)
                {
                    Uri url = new Uri(el.GetAttribute("url"));
                    TreeNode node = new TreeNode(el.InnerText, tree.ImageList.Images.IndexOfKey(url.Host.ToString()), tree.ImageList.Images.IndexOfKey(url.Host.ToString()));
                    node.ToolTipText = el.GetAttribute("url");
                    node.Name = el.GetAttribute("url");
                    node.ContextMenuStrip = ORGANIZEfavoritesContextMenu;
                    ORGANIZEfavoritesTreeView.Nodes[0].Nodes.Add(node);
                }

            }


        }


        public OrganizeFav(TreeView tree, ContextMenuStrip linkContext, ContextMenuStrip favContext)
        {
            this.tree = tree;
            this.linkContext = linkContext;
            this.favContext = favContext;

            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //rename method
        private void rename()
        {
            if (ORGANIZEfavoritesTreeView.SelectedNode.Index >= 0)
            {
                String file = "";
                RenameLink rl = new RenameLink(ORGANIZEfavoritesTreeView.SelectedNode.Text);
                TreeNode node = ORGANIZEfavoritesTreeView.SelectedNode;

                if (rl.ShowDialog() == DialogResult.OK)
                {
                    node.Text = rl.newName.Text;

                    if (ORGANIZEfavoritesTreeView.Nodes[0].Nodes.Contains(node))
                    {
                        if (tree.Visible == true)
                            tree.Nodes[0].Nodes[node.Name].Text = rl.newName.Text;
                        file = linksXml;

                    }
                    else
                    {
                        if (tree.Visible == true)
                            tree.Nodes[node.Name].Text = rl.newName.Text;
                        file = favXml;
                    }
                }

                XmlDocument myXml = new XmlDocument();
                myXml.Load(file);
                foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
                {
                    if (x.GetAttribute("url").Equals(node.Name))
                    {
                        x.InnerText = rl.newName.Text;
                        break;
                    }
                }

                myXml.Save(file);

                rl.Close();
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rename();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rename();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void ORGANIZEfavoritesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ORGANIZEfavoritesTreeView.SelectedNode = e.Node;
            }
        }

        //delete method       
        private void delete()
        {
            if (ORGANIZEfavoritesTreeView.SelectedNode.Index >= 0)
            {
                String file = "";
                TreeNode node = ORGANIZEfavoritesTreeView.SelectedNode;

                if (ORGANIZEfavoritesTreeView.Nodes[0].Nodes.Contains(node))
                {
                    if (tree.Visible == true)
                        tree.Nodes[0].Nodes[node.Name].Remove();
                    file = linksXml;

                }
                else
                {
                    if (tree.Visible == true)
                        tree.Nodes[node.Name].Remove();
                    file = favXml;
                }

                node.Remove();
                XmlDocument myXml = new XmlDocument();
                myXml.Load(file);
                XmlElement root = myXml.DocumentElement;
                foreach (XmlElement x in root.ChildNodes)
                {
                    if (x.GetAttribute("url").Equals(node.Name))
                    {
                        root.RemoveChild(x);
                        break;
                    }
                }

                myXml.Save(file);
            }
        }

        public void move()
        {
            if (ORGANIZEfavoritesTreeView.SelectedNode.Index >= 0)
            {
                String dest = "", source = "", element = "";
                TreeNode node = ORGANIZEfavoritesTreeView.SelectedNode;

                if (ORGANIZEfavoritesTreeView.Nodes[0].Nodes.Contains(node))
                {
                    ORGANIZEfavoritesTreeView.SelectedNode.Remove();
                    ORGANIZEfavoritesTreeView.Nodes.Add(node);

                    dest = favXml;
                    source = linksXml;
                    element = "favorit";

                    if (tree.Visible == true)
                    {
                        tree.Nodes[0].Nodes.RemoveByKey(node.Name);
                        node.ContextMenuStrip = favContext;
                        tree.Nodes.Add(node);
                    }

                }
                else
                {
                    dest = linksXml;
                    source = favXml;
                    element = "link";

                    ORGANIZEfavoritesTreeView.SelectedNode.Remove();
                    ORGANIZEfavoritesTreeView.Nodes[0].Nodes.Add(node);
                    if (tree.Visible == true)
                    {
                        tree.Nodes.RemoveByKey(node.Name);
                        node.ContextMenuStrip = linkContext;
                        tree.Nodes[0].Nodes.Add(node);
                    }
                    //if (linkbar.Visible == true)


                }

                XmlDocument sourceXml = new XmlDocument();
                XmlDocument destXml = new XmlDocument();
                sourceXml.Load(source);
                destXml.Load(dest);
                XmlElement el = destXml.CreateElement(element);
                el.SetAttribute("url", node.ToolTipText);
                el.InnerText = node.Text;
                destXml.DocumentElement.AppendChild(el);

                XmlElement root = sourceXml.DocumentElement;

                foreach (XmlElement elem in root.ChildNodes)
                {
                    if (elem.GetAttribute("url").Equals(node.ToolTipText))
                    {
                        root.RemoveChild(elem);
                        break;
                    }
                }
                destXml.Save(dest);
                sourceXml.Save(source);
            }
        }


    }
}
