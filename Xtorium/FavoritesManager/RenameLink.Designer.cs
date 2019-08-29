namespace Xtorium
{
    partial class RenameLink
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameLink));
            this.panel2forButton2 = new XtoriumGradientPanel64();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1forButton1 = new XtoriumGradientPanel64();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.panel2forButton2.SuspendLayout();
            this.panel1forButton1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2forButton2
            // 
            this.panel2forButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2forButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2forButton2.BackgroundImage")));
            this.panel2forButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2forButton2.Controls.Add(this.button2);
            this.panel2forButton2.EndColor = System.Drawing.Color.Empty;
            this.panel2forButton2.Location = new System.Drawing.Point(293, 148);
            this.panel2forButton2.Name = "panel2forButton2";
            this.panel2forButton2.Size = new System.Drawing.Size(147, 41);
            this.panel2forButton2.StartColor = System.Drawing.Color.Empty;
            this.panel2forButton2.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1forButton1
            // 
            this.panel1forButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1forButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1forButton1.BackgroundImage")));
            this.panel1forButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1forButton1.Controls.Add(this.button3);
            this.panel1forButton1.EndColor = System.Drawing.Color.Empty;
            this.panel1forButton1.Location = new System.Drawing.Point(0, 148);
            this.panel1forButton1.Name = "panel1forButton1";
            this.panel1forButton1.Size = new System.Drawing.Size(293, 41);
            this.panel1forButton1.StartColor = System.Drawing.Color.Empty;
            this.panel1forButton1.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-6, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Rename";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rename link";
            // 
            // newName
            // 
            this.newName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newName.Location = new System.Drawing.Point(17, 53);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(378, 33);
            this.newName.TabIndex = 30;
            // 
            // RenameLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.panel2forButton2);
            this.Controls.Add(this.panel1forButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameLink";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenameLink";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RenameLink_Load);
            this.panel2forButton2.ResumeLayout(false);
            this.panel1forButton1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtoriumGradientPanel64 panel2forButton2;
        private System.Windows.Forms.Button button2;
        private XtoriumGradientPanel64 panel1forButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox newName;
    }
}