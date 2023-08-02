using System;
using System.Drawing;
using System.Windows.Forms;

namespace _028_Demo_UfakOyunlar
{
    public partial class YaziTuraForm : Form
    {
        Random rasgele = new Random();
        bool test = false;
        byte rasgelePara;
        string path;
        bool yazi;
        int timerDegeri;
        int timerSonlandirmaDegeri = 10;

        public YaziTuraForm()
        {
            InitializeComponent();
        }

        private void YaziTuraForm_Load(object sender, EventArgs e)
        {
            lRasgeleSayi.Visible = test;
            path = Application.StartupPath.Replace(@"\bin\Debug", @"\YaziTuraDosyalar\");
        }

        private void RasgeleSayiOlustur()
        {
            rasgelePara = Convert.ToByte(rasgele.Next(0, 2));
            lRasgeleSayi.Text = rasgelePara.ToString();
            pbRasgeleSayi.Image = Image.FromFile(path + rasgelePara + ".png");
        }

        private void bPara_Click(object sender, EventArgs e)
        {
            yazi = true;
            timerDegeri = 1;
            timer1.Start();
        }

        private void YaziMiTuraMi()
        {
            byte secim = 1; // 1: tura, 0: yazı
            if (rbYazi.Checked)
                secim = 0;
            if (secim == rasgelePara)
                lbSonuc.Items.Add("Bildiniz");
            else
                lbSonuc.Items.Add("Bilemediniz");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerDegeri > timerSonlandirmaDegeri)
            {
                timer1.Stop();
                RasgeleSayiOlustur();
                YaziMiTuraMi();
            }
            else
            {
                if (yazi)
                    pbRasgeleSayi.Image = Image.FromFile(path + "1.png");
                else
                    pbRasgeleSayi.Image = Image.FromFile(path + "0.png");
                //if (yazi)
                //    yazi = false;
                //else
                //    yazi = true;
                yazi = !yazi;
                timerDegeri++;
            }
        }

        private void bYeni_Click(object sender, EventArgs e)
        {
            rbYazi.Checked = true;
            lRasgeleSayi.Text = "";
            pbRasgeleSayi.Image = null;
            lbSonuc.Items.Clear();
        }

        private void bSans_Click(object sender, EventArgs e)
        {
            double toplam = lbSonuc.Items.Count;
            double bilinen = 0;
            double yuzde = 0;
            if (toplam == 0)
            {
                MessageBox.Show("Lütfen önce oyunu oynayın...", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            foreach (var item in lbSonuc.Items)
            {
                if (item.ToString() == "Bildiniz")
                    bilinen++;
            }
            yuzde = bilinen / toplam * 100;
            if (yuzde >= 50)
                MessageBox.Show("Bugün şanslı günün.");
            else
                MessageBox.Show("Bugün şanssız günün.");
        }
    }
}
