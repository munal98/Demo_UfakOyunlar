
namespace _028_Demo_UfakOyunlar
{
    partial class YaziTuraForm
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
            this.bPara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbYazi = new System.Windows.Forms.RadioButton();
            this.rbTura = new System.Windows.Forms.RadioButton();
            this.lRasgeleSayi = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.pbRasgeleSayi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bYeni = new System.Windows.Forms.Button();
            this.bSans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRasgeleSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // bPara
            // 
            this.bPara.Location = new System.Drawing.Point(15, 38);
            this.bPara.Name = "bPara";
            this.bPara.Size = new System.Drawing.Size(75, 23);
            this.bPara.TabIndex = 0;
            this.bPara.Text = "Parayı At";
            this.bPara.UseVisualStyleBackColor = true;
            this.bPara.Click += new System.EventHandler(this.bPara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazı mı tura mı?";
            // 
            // rbYazi
            // 
            this.rbYazi.AutoSize = true;
            this.rbYazi.Checked = true;
            this.rbYazi.Location = new System.Drawing.Point(98, 11);
            this.rbYazi.Name = "rbYazi";
            this.rbYazi.Size = new System.Drawing.Size(45, 17);
            this.rbYazi.TabIndex = 2;
            this.rbYazi.TabStop = true;
            this.rbYazi.Text = "Yazı";
            this.rbYazi.UseVisualStyleBackColor = true;
            // 
            // rbTura
            // 
            this.rbTura.AutoSize = true;
            this.rbTura.Location = new System.Drawing.Point(149, 11);
            this.rbTura.Name = "rbTura";
            this.rbTura.Size = new System.Drawing.Size(47, 17);
            this.rbTura.TabIndex = 2;
            this.rbTura.Text = "Tura";
            this.rbTura.UseVisualStyleBackColor = true;
            // 
            // lRasgeleSayi
            // 
            this.lRasgeleSayi.AutoSize = true;
            this.lRasgeleSayi.Location = new System.Drawing.Point(121, 67);
            this.lRasgeleSayi.Name = "lRasgeleSayi";
            this.lRasgeleSayi.Size = new System.Drawing.Size(68, 13);
            this.lRasgeleSayi.TabIndex = 3;
            this.lRasgeleSayi.Text = "lRasgeleSayi";
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(15, 183);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbSonuc.Size = new System.Drawing.Size(268, 199);
            this.lbSonuc.TabIndex = 4;
            // 
            // pbRasgeleSayi
            // 
            this.pbRasgeleSayi.Location = new System.Drawing.Point(15, 67);
            this.pbRasgeleSayi.Name = "pbRasgeleSayi";
            this.pbRasgeleSayi.Size = new System.Drawing.Size(100, 100);
            this.pbRasgeleSayi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRasgeleSayi.TabIndex = 5;
            this.pbRasgeleSayi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bYeni
            // 
            this.bYeni.Location = new System.Drawing.Point(96, 38);
            this.bYeni.Name = "bYeni";
            this.bYeni.Size = new System.Drawing.Size(75, 23);
            this.bYeni.TabIndex = 0;
            this.bYeni.Text = "Yeni Oyun";
            this.bYeni.UseVisualStyleBackColor = true;
            this.bYeni.Click += new System.EventHandler(this.bYeni_Click);
            // 
            // bSans
            // 
            this.bSans.Location = new System.Drawing.Point(177, 38);
            this.bSans.Name = "bSans";
            this.bSans.Size = new System.Drawing.Size(109, 23);
            this.bSans.TabIndex = 0;
            this.bSans.Text = "Şansımı Hesapla";
            this.bSans.UseVisualStyleBackColor = true;
            this.bSans.Click += new System.EventHandler(this.bSans_Click);
            // 
            // YaziTuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 461);
            this.Controls.Add(this.pbRasgeleSayi);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lRasgeleSayi);
            this.Controls.Add(this.rbTura);
            this.Controls.Add(this.rbYazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSans);
            this.Controls.Add(this.bYeni);
            this.Controls.Add(this.bPara);
            this.Name = "YaziTuraForm";
            this.Text = "Yazı Tura";
            this.Load += new System.EventHandler(this.YaziTuraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRasgeleSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbYazi;
        private System.Windows.Forms.RadioButton rbTura;
        private System.Windows.Forms.Label lRasgeleSayi;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.PictureBox pbRasgeleSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bYeni;
        private System.Windows.Forms.Button bSans;
    }
}