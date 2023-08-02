using System;
using System.Windows.Forms;
using _028_Demo_UfakOyunlar.SehirBulma;

namespace _028_Demo_UfakOyunlar
{
    public partial class SehirBulmaForm : Form
    {
        SehirBulmaManager sehirBulmaManager = new SehirBulmaManager();

        string path = Application.StartupPath
                          .Replace(@"bin\Debug", "SehirBulma")
                          .Replace(@"bin\Release", "SehirBulma")
                      + @"\Şehirler.txt";

        public SehirBulmaForm()
        {
            InitializeComponent();
        }

        private void SehirBulmaForm_Load(object sender, EventArgs e)
        {
            //string[] sehirler = new string[5]
            //{
            //    "Ankara", "İstanbul", "İzmir", "Antalya", "Van"
            //};
            ////foreach (string sehir in sehirler)
            ////{
            ////    lbSehir.Items.Add(sehir);
            ////}
            //lbSehir.Items.AddRange(sehirler);

            //lbSehir.Items.AddRange(sehirBulmaManager.SehirleriDoldur());
            lbSehir.Items.AddRange(sehirBulmaManager.SehirleriDoldur(path));
        }

        private void bTahminEt_Click(object sender, EventArgs e)
        {
            string sonuc = sehirBulmaManager.SehriTahminEt(tbSehir.Text);
            MessageBox.Show(sonuc, "Tahmin Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
