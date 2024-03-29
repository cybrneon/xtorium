﻿namespace Xtorium
{
    partial class exitBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exitBox));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1forButton1 = new XtoriumGradientPanel64();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2forButton2 = new XtoriumGradientPanel64();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1forButton1.SuspendLayout();
            this.panel2forButton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Are you sure you want to close Xtorium?";
            // 
            // panel1forButton1
            // 
            this.panel1forButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1forButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1forButton1.BackgroundImage")));
            this.panel1forButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1forButton1.Controls.Add(this.button1);
            this.panel1forButton1.EndColor = System.Drawing.Color.Empty;
            this.panel1forButton1.Location = new System.Drawing.Point(0, 148);
            this.panel1forButton1.Name = "panel1forButton1";
            this.panel1forButton1.Size = new System.Drawing.Size(293, 41);
            this.panel1forButton1.StartColor = System.Drawing.Color.Empty;
            this.panel1forButton1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(195)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel2forButton2.TabIndex = 20;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Some tabs are still open";
            // 
            // exitBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 189);
            this.ControlBox = false;
            this.Controls.Add(this.panel2forButton2);
            this.Controls.Add(this.panel1forButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "exitBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.exitBox_Load);
            this.panel1forButton1.ResumeLayout(false);
            this.panel2forButton2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XtoriumGradientPanel64 panel1forButton1;
        private System.Windows.Forms.Button button1;
        private XtoriumGradientPanel64 panel2forButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}