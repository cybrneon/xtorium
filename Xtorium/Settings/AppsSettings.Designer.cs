namespace Xtorium
{
    partial class AppsSettings
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Clock"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Files Manager (Beta)", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Note10 (Beta)", 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Spotify", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Sticky Notes", 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Telegram");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppsSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appListView = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmationPanel = new XtoriumGradientPanel64();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.ConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 83;
            this.label3.Text = "Apps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(319, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 26);
            this.label6.TabIndex = 90;
            this.label6.Text = "All of these settings don\'t work and are in\r\npreparation. This is just a layout.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appListView
            // 
            this.appListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appListView.BackColor = System.Drawing.Color.White;
            this.appListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appListView.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.appListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.appListView.Location = new System.Drawing.Point(15, 73);
            this.appListView.MultiSelect = false;
            this.appListView.Name = "appListView";
            this.appListView.Size = new System.Drawing.Size(528, 217);
            this.appListView.TabIndex = 89;
            this.appListView.TileSize = new System.Drawing.Size(204, 30);
            this.appListView.UseCompatibleStateImageBehavior = false;
            this.appListView.View = System.Windows.Forms.View.Tile;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(15, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 87;
            this.button2.Text = "Uninstall";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(468, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 88;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Separate Window",
            "Separate Tab"});
            this.comboBox1.Location = new System.Drawing.Point(15, 353);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 86;
            this.comboBox1.Text = "Separate Tab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Open apps in :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Installed apps :";
            // 
            // ConfirmationPanel
            // 
            this.ConfirmationPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ConfirmationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmationPanel.BackgroundImage")));
            this.ConfirmationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmationPanel.Controls.Add(this.ConfirmationLabel);
            this.ConfirmationPanel.EndColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.Location = new System.Drawing.Point(15, 415);
            this.ConfirmationPanel.Name = "ConfirmationPanel";
            this.ConfirmationPanel.Size = new System.Drawing.Size(528, 28);
            this.ConfirmationPanel.StartColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.TabIndex = 91;
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.AutoSize = true;
            this.ConfirmationLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConfirmationLabel.Location = new System.Drawing.Point(3, 5);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(101, 19);
            this.ConfirmationLabel.TabIndex = 89;
            this.ConfirmationLabel.Text = "Settings saved!";
            // 
            // AppsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppsSettings";
            this.Size = new System.Drawing.Size(558, 530);
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView appListView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private XtoriumGradientPanel64 ConfirmationPanel;
        private System.Windows.Forms.Label ConfirmationLabel;
    }
}
