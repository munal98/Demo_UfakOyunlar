using System;
using System.IO;

namespace _028_Demo_UfakOyunlar.SehirBulma
{
    public class SehirBulmaManager // SehirBulmaService
    {
        string[] sehirler;
        Random random = new Random();

        public string[] SehirleriDoldur()
        {
            sehirler = new string[5]
            {
                "Ankara", "İstanbul", "İzmir", "Antalya", "Van"
            };
            return sehirler;
        }

        public string[] SehirleriDoldur(string path)
        {
            sehirler = File.ReadAllLines(path);
            return sehirler;
        }

        public string SehriTahminEt(string girilenSehir)
        {
            string tahminSonucu = GirilenSehriKontrolEt(girilenSehir);
            if (tahminSonucu != "")
                return tahminSonucu;

            int rasgeleIndex = random.Next(0, sehirler.Length);

            if (GirilenSehirListedeVarMi(girilenSehir, rasgeleIndex))
            {
                tahminSonucu = "Tebrikler, şehri bildiniz. Rasgele gelen şehir: " + sehirler[rasgeleIndex];
            }
            else
            {
                tahminSonucu = "Üzgünüm, şehri bilemediniz. Rasgele gelen şehir: " + sehirler[rasgeleIndex];
            }

            return tahminSonucu;
        }

        public string GirilenSehriKontrolEt(string girilenSehir)
        {
            string kontrolSonucu = "";

            //if (girilenSehir == "")
            if (string.IsNullOrWhiteSpace(girilenSehir))
            {
                kontrolSonucu = "Lütfen şehir giriniz...";
            }
            else
            {
                bool sehirListedeBulunduMu = false;
                for (int s = 0; s < sehirler.Length; s++)
                {
                    if (GirilenSehirListedeVarMi(girilenSehir, s))
                    {
                        sehirListedeBulunduMu = true;
                        break;
                    }
                }

                if (!sehirListedeBulunduMu)
                    kontrolSonucu = "Lütfen listede bulunan bir şehri giriniz...";
            }

            return kontrolSonucu;
        }

        public bool GirilenSehirListedeVarMi(string girilenSehir, int index)
        {
            return girilenSehir.ToUpper().Trim() == sehirler[index].ToUpper();
        }
    }
}
