
namespace _028_Demo_UfakOyunlar
{
    partial class SayiBulmaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bTahminEt = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.lRasgeleSayi = new System.Windows.Forms.Label();
            this.bYeniOyun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlZorluk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen 1 ile 9 arasında bir tam sayı girin...";
            // 
            // bTahminEt
            // 
            this.bTahminEt.Location = new System.Drawing.Point(15, 94);
            this.bTahminEt.Name = "bTahminEt";
            this.bTahminEt.Size = new System.Drawing.Size(100, 23);
            this.bTahminEt.TabIndex = 2;
            this.bTahminEt.Text = "Sayıyı Tahmin Et";
            this.bTahminEt.UseVisualStyleBackColor = true;
            this.bTahminEt.Click += new System.EventHandler(this.bTahminEt_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.ForeColor = System.Drawing.Color.Maroon;
            this.lSonuc.Location = new System.Drawing.Point(12, 129);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(40, 13);
            this.lSonuc.TabIndex = 3;
            this.lSonuc.Text = "lSonuc";
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(15, 68);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(100, 20);
            this.tbSayi.TabIndex = 4;
            this.tbSayi.TextChanged += new System.EventHandler(this.tbSayi_TextChanged);
            // 
            // lRasgeleSayi
            // 
            this.lRasgeleSayi.AutoSize = true;
            this.lRasgeleSayi.Location = new System.Drawing.Point(12, 151);
            this.lRasgeleSayi.Name = "lRasgeleSayi";
            this.lRasgeleSayi.Size = new System.Drawing.Size(68, 13);
            this.lRasgeleSayi.TabIndex = 5;
            this.lRasgeleSayi.Text = "lRasgeleSayi";
            // 
            // bYeniOyun
            // 
            this.bYeniOyun.Location = new System.Drawing.Point(121, 94);
            this.bYeniOyun.Name = "bYeniOyun";
            this.bYeniOyun.Size = new System.Drawing.Size(100, 23);
            this.bYeniOyun.TabIndex = 6;
            this.bYeniOyun.Text = "Yeni Oyun";
            this.bYeniOyun.UseVisualStyleBackColor = true;
            this.bYeniOyun.Click += new System.EventHandler(this.bYeniOyun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seviye:";
            // 
            // ddlZorluk
            // 
            this.ddlZorluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlZorluk.FormattingEnabled = true;
            this.ddlZorluk.Location = new System.Drawing.Point(63, 10);
            this.ddlZorluk.Name = "ddlZorluk";
            this.ddlZorluk.Size = new System.Drawing.Size(158, 21);
            this.ddlZorluk.TabIndex = 8;
            this.ddlZorluk.SelectedIndexChanged += new System.EventHandler(this.ddlZorluk_SelectedIndexChanged);
            // 
            // SayiBulmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 451);
            this.Controls.Add(this.ddlZorluk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bYeniOyun);
            this.Controls.Add(this.lRasgeleSayi);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.bTahminEt);
            this.Controls.Add(this.label1);
            this.Name = "SayiBulmaForm";
            this.Text = "Sayı Bulma";
            this.Load += new System.EventHandler(this.SayiBulmaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bTahminEt;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Label lRasgeleSayi;
        private System.Windows.Forms.Button bYeniOyun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlZorluk;
    }
}