using System;
using System.Collections.Concurrent;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";

            //Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı giriş yapmış.");
            } else
            {
                Console.WriteLine("Kullanıcı giris yapmamış.");
            }


            string[] kurslar = new string[] { "Yazılım Gelistirme Kampı", "Programlamaya baslangıc", "Java", "Python","C#" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("For Bitti \n");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            

        }
    }
}