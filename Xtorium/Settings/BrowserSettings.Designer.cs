namespace Xtorium
{
    partial class BrowserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserSettings));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.URLHome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.URLHomeButon = new System.Windows.Forms.TextBox();
            this.ConfirmationPanel = new XtoriumGradientPanel64();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.ConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(468, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 74;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "DuckDuckGo"});
            this.comboBox1.Location = new System.Drawing.Point(405, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 33);
            this.comboBox1.TabIndex = 73;
            // 
            // URLHome
            // 
            this.URLHome.BackColor = System.Drawing.Color.White;
            this.URLHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLHome.Location = new System.Drawing.Point(15, 111);
            this.URLHome.Name = "URLHome";
            this.URLHome.Size = new System.Drawing.Size(528, 26);
            this.URLHome.TabIndex = 72;
            this.URLHome.Text = "url";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Default search engine :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "When Xtorium starts :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "Browser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Choose the default search engine to use in the search bar.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Choose the page to open on startup.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Home button :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Choose the page to open when pressing the home button.";
            // 
            // URLHomeButon
            // 
            this.URLHomeButon.BackColor = System.Drawing.Color.White;
            this.URLHomeButon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLHomeButon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLHomeButon.Location = new System.Drawing.Point(15, 208);
            this.URLHomeButon.Name = "URLHomeButon";
            this.URLHomeButon.Size = new System.Drawing.Size(528, 26);
            this.URLHomeButon.TabIndex = 72;
            this.URLHomeButon.Text = "url";
            // 
            // ConfirmationPanel
            // 
            this.ConfirmationPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ConfirmationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmationPanel.BackgroundImage")));
            this.ConfirmationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmationPanel.Controls.Add(this.ConfirmationLabel);
            this.ConfirmationPanel.EndColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.Location = new System.Drawing.Point(15, 389);
            this.ConfirmationPanel.Name = "ConfirmationPanel";
            this.ConfirmationPanel.Size = new System.Drawing.Size(528, 28);
            this.ConfirmationPanel.StartColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.TabIndex = 89;
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
            // BrowserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.URLHomeButon);
            this.Controls.Add(this.URLHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrowserSettings";
            this.Size = new System.Drawing.Size(558, 530);
            this.Load += new System.EventHandler(this.BrowserSettings_Load);
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox URLHome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox URLHomeButon;
        private XtoriumGradientPanel64 ConfirmationPanel;
        private System.Windows.Forms.Label ConfirmationLabel;
    }
}
