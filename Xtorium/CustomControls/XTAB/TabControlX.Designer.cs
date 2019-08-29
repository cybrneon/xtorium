namespace Xtorium.CustomControls.XTAB
{
    partial class TabControlX
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlX));
            this.BackTopPanel = new System.Windows.Forms.Panel();
            this.RibbonPanel = new System.Windows.Forms.Panel();
            this.TabButtonPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.BackTopPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackTopPanel
            // 
            this.BackTopPanel.Controls.Add(this.toolStrip1);
            this.BackTopPanel.Controls.Add(this.TabButtonPanel);
            this.BackTopPanel.Controls.Add(this.RibbonPanel);
            this.BackTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackTopPanel.Location = new System.Drawing.Point(0, 0);
            this.BackTopPanel.Name = "BackTopPanel";
            this.BackTopPanel.Size = new System.Drawing.Size(418, 40);
            this.BackTopPanel.TabIndex = 0;
            // 
            // RibbonPanel
            // 
            this.RibbonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.RibbonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RibbonPanel.Location = new System.Drawing.Point(0, 38);
            this.RibbonPanel.Name = "RibbonPanel";
            this.RibbonPanel.Size = new System.Drawing.Size(418, 2);
            this.RibbonPanel.TabIndex = 0;
            // 
            // TabButtonPanel
            // 
            this.TabButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.TabButtonPanel.Name = "TabButtonPanel";
            this.TabButtonPanel.Size = new System.Drawing.Size(374, 37);
            this.TabButtonPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(377, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(41, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.DropDownOpening += new System.EventHandler(this.toolStripDropDownButton1_DropDownOpening);
            // 
            // TabPanel
            // 
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 40);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(418, 234);
            this.TabPanel.TabIndex = 1;
            // 
            // TabControlX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.BackTopPanel);
            this.Name = "TabControlX";
            this.Size = new System.Drawing.Size(418, 274);
            this.BackTopPanel.ResumeLayout(false);
            this.BackTopPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackTopPanel;
        private System.Windows.Forms.Panel TabButtonPanel;
        private System.Windows.Forms.Panel RibbonPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Panel TabPanel;
    }
}
