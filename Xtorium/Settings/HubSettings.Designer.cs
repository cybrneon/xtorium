namespace Xtorium
{
    partial class HubSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmationPanel = new XtoriumGradientPanel64();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 84;
            this.label1.Text = "Hub";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(320, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 26);
            this.label6.TabIndex = 83;
            this.label6.Text = "All of these settings don\'t work and are in\r\npreparation. This is just a layout.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.button1.Location = new System.Drawing.Point(469, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 81;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(15, 167);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 21);
            this.checkBox4.TabIndex = 75;
            this.checkBox4.Text = "AppsEmbedded";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 21);
            this.checkBox1.TabIndex = 78;
            this.checkBox1.Text = "Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Elements to display in the hub :";
            // 
            // ConfirmationPanel
            // 
            this.ConfirmationPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ConfirmationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmationPanel.BackgroundImage")));
            this.ConfirmationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmationPanel.Controls.Add(this.ConfirmationLabel);
            this.ConfirmationPanel.EndColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.Location = new System.Drawing.Point(15, 435);
            this.ConfirmationPanel.Name = "ConfirmationPanel";
            this.ConfirmationPanel.Size = new System.Drawing.Size(529, 28);
            this.ConfirmationPanel.StartColor = System.Drawing.Color.Empty;
            this.ConfirmationPanel.TabIndex = 92;
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(15, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 21);
            this.checkBox2.TabIndex = 75;
            this.checkBox2.Text = "Apps";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Select the items displayed on your hub";
            // 
            // HubSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HubSettings";
            this.Size = new System.Drawing.Size(558, 530);
            this.Load += new System.EventHandler(this.HubSettings_Load);
            this.ConfirmationPanel.ResumeLayout(false);
            this.ConfirmationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private XtoriumGradientPanel64 ConfirmationPanel;
        private System.Windows.Forms.Label ConfirmationLabel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
    }
}
