
namespace _028_Demo_UfakOyunlar
{
    partial class SehirBulmaForm
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
            this.bTahminEt = new System.Windows.Forms.Button();
            this.lbSehir = new System.Windows.Forms.ListBox();
            this.tbSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTahminEt
            // 
            this.bTahminEt.Location = new System.Drawing.Point(15, 178);
            this.bTahminEt.Name = "bTahminEt";
            this.bTahminEt.Size = new System.Drawing.Size(279, 23);
            this.bTahminEt.TabIndex = 7;
            this.bTahminEt.Text = "Şehri Tahmin Et";
            this.bTahminEt.UseVisualStyleBackColor = true;
            this.bTahminEt.Click += new System.EventHandler(this.bTahminEt_Click);
            // 
            // lbSehir
            // 
            this.lbSehir.FormattingEnabled = true;
            this.lbSehir.Location = new System.Drawing.Point(12, 12);
            this.lbSehir.Name = "lbSehir";
            this.lbSehir.Size = new System.Drawing.Size(282, 134);
            this.lbSehir.TabIndex = 6;
            // 
            // tbSehir
            // 
            this.tbSehir.Location = new System.Drawing.Point(49, 152);
            this.tbSehir.Name = "tbSehir";
            this.tbSehir.Size = new System.Drawing.Size(245, 20);
            this.tbSehir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şehir";
            // 
            // SehirBulmaForm
            // 
            this.AcceptButton = this.bTahminEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 213);
            this.Controls.Add(this.bTahminEt);
            this.Controls.Add(this.lbSehir);
            this.Controls.Add(this.tbSehir);
            this.Controls.Add(this.label1);
            this.Name = "SehirBulmaForm";
            this.Text = "Şehir Bulma";
            this.Load += new System.EventHandler(this.SehirBulmaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTahminEt;
        private System.Windows.Forms.ListBox lbSehir;
        private System.Windows.Forms.TextBox tbSehir;
        private System.Windows.Forms.Label label1;
    }
}