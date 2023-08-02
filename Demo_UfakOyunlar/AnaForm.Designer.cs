
namespace _028_Demo_UfakOyunlar
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sayıBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.şehirBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayıBulmaToolStripMenuItem,
            this.yazıTuraToolStripMenuItem,
            this.şehirBulmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sayıBulmaToolStripMenuItem
            // 
            this.sayıBulmaToolStripMenuItem.Name = "sayıBulmaToolStripMenuItem";
            this.sayıBulmaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.sayıBulmaToolStripMenuItem.Text = "Sayı Bulma";
            this.sayıBulmaToolStripMenuItem.Click += new System.EventHandler(this.sayıBulmaToolStripMenuItem_Click);
            // 
            // yazıTuraToolStripMenuItem
            // 
            this.yazıTuraToolStripMenuItem.Name = "yazıTuraToolStripMenuItem";
            this.yazıTuraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.yazıTuraToolStripMenuItem.Text = "Yazı Tura";
            this.yazıTuraToolStripMenuItem.Click += new System.EventHandler(this.yazıTuraToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // şehirBulmaToolStripMenuItem
            // 
            this.şehirBulmaToolStripMenuItem.Name = "şehirBulmaToolStripMenuItem";
            this.şehirBulmaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.şehirBulmaToolStripMenuItem.Text = "Şehir Bulma";
            this.şehirBulmaToolStripMenuItem.Click += new System.EventHandler(this.şehirBulmaToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Ufak Oyunlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sayıBulmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTuraToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem şehirBulmaToolStripMenuItem;
    }
}

