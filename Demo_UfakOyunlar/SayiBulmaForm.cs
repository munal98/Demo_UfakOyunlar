using System;
using System.Windows.Forms;

namespace _028_Demo_UfakOyunlar
{
    public partial class SayiBulmaForm : Form
    {
        Random rasgele = new Random();
        int rasgeleSayi;
        int kucukAralik = 2;
        int buyukAralik = 4;
        bool test = false;
        int toplamHak = 4;
        int hak = 1;

        public SayiBulmaForm()
        {
            InitializeComponent();
        }

        private void SayiBulmaForm_Load(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            RasgeleSayiOlustur();
            lRasgeleSayi.Visible = test;
            ZorlukDoldur();
        }

        void ZorlukDoldur()
        {
            //ddlZorluk.Items.Add("Kolay");
            //ddlZorluk.Items.Add("Zor");
            string[] zorluklar = new string[] { "Kolay", "Zor" };
            ddlZorluk.Items.AddRange(zorluklar);
            ddlZorluk.SelectedIndex = 0;
        }

        private void bTahminEt_Click(object sender, EventArgs e)
        {
            int sayi;
            //if (tbSayi.Text.Trim() == "")
            //if (string.IsNullOrWhiteSpace(tbSayi.Text))
            //{
            //    MessageBox.Show("Lütfen boş giriş yapmayınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
            //else
            //{
            //    if (!int.TryParse(tbSayi.Text.Trim(), out sayi))
            //    {
            //        MessageBox.Show("Lütfen karakter girmeyiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        if (!(sayi >= 1 && sayi <= 9))
            //        {
            //            MessageBox.Show("Lütfen 1 ile 9 arasında bir tam sayı girer misiniz?", "Soru?", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //        }
            //        else
            //        {
            //            // sayı bulma işlemi
            //        }
            //    }
            //}
            lSonuc.Text = "";
            if (string.IsNullOrWhiteSpace(tbSayi.Text))
            {
                //MessageBox.Show("Lütfen boş giriş yapmayınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                lSonuc.Text = "Lütfen boş giriş yapmayınız!";
                return;
            }
            if (!int.TryParse(tbSayi.Text.Trim(), out sayi))
            {
                MessageBox.Show("Lütfen karakter girmeyiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(sayi >= 1 && sayi <= 9))
            {
                MessageBox.Show("Lütfen 1 ile 9 arasında bir tam sayı girer misiniz?", "Soru?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            // sayı bulma işlemi
            if (hak <= toplamHak)
            {
                SayiBul(sayi);
                hak++;
                ddlZorluk.Enabled = false;
            }
            else
            {
                lSonuc.Text = "Hakkınız bitti, sayıyı bulmadınız.";
                bTahminEt.Enabled = false;
                tbSayi.ReadOnly = true;
            }
        }

        void RasgeleSayiOlustur()
        {
            rasgeleSayi = rasgele.Next(1, 10);
            lRasgeleSayi.Text = rasgeleSayi.ToString();
        }

        private void SayiBul(int sayi)
        {
            lSonuc.Text = "";
            if (sayi == rasgeleSayi)
            {
                lSonuc.Text = "Tebrikler, sayıyı buldunuz.";
                bTahminEt.Enabled = false;
                tbSayi.ReadOnly = true;
            }
            else if (sayi >= rasgeleSayi - kucukAralik && sayi <= rasgeleSayi + kucukAralik)
            {
                lSonuc.Text = "Sayıyı bulmaya çok yakınsınız.";
            }
            else if (sayi >= rasgeleSayi - buyukAralik && sayi <= rasgeleSayi + buyukAralik)
            {
                lSonuc.Text = "Sayıyı bulmaya yakınsınız.";
            }
            else
            {
                lSonuc.Text = "Sayıyı bulmaya uzaksınız.";
            }
        }

        private void bYeniOyun_Click(object sender, EventArgs e)
        {
            bTahminEt.Enabled = true;
            tbSayi.ReadOnly = false;
            tbSayi.Clear();
            hak = 1;
            RasgeleSayiOlustur();
            lSonuc.Text = "";
            ddlZorluk.Enabled = true;
        }

        private void tbSayi_TextChanged(object sender, EventArgs e)
        {
            bTahminEt_Click(null, null);
        }

        private void ddlZorluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlZorluk.SelectedIndex == 1) // zor
            {
                toplamHak = 3;
                kucukAralik = 1;
                buyukAralik = 3;
            }
            else // kolay
            {
                toplamHak = 4;
                kucukAralik = 2;
                buyukAralik = 4;
            }
        }
    }
}
