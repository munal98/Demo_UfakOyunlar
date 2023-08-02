using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _028_Demo_UfakOyunlar
{
    public partial class AnaForm : Form
    {
        DateTime simdi;
        const string formTitle = "Ufak Oyunlar";

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            SimdiyiGetir();

            //timer1.Enabled = true;
            timer1.Start();
        }

        private void sayıBulmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayiBulmaForm sayiBulmaForm = new SayiBulmaForm();
            sayiBulmaForm.MdiParent = this;
            sayiBulmaForm.WindowState = FormWindowState.Maximized;
            sayiBulmaForm.Show();
        }

        private void yazıTuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziTuraForm yaziTuraForm = new YaziTuraForm();
            yaziTuraForm.MdiParent = this;
            yaziTuraForm.WindowState = FormWindowState.Maximized;
            yaziTuraForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SimdiyiGetir();
        }

        private void SimdiyiGetir()
        {
            simdi = DateTime.Now;
            this.Text = formTitle + " | " + simdi.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //timer1.Enabled = false;
            timer1.Stop();
        }

        private void şehirBulmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SehirBulmaForm sehirBulmaForm = new SehirBulmaForm();
            sehirBulmaForm.MdiParent = this;
            sehirBulmaForm.WindowState = FormWindowState.Maximized;
            sehirBulmaForm.Show();
        }
    }
}
