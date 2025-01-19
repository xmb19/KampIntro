using System;
using System.Collections.Concurrent;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad = "Engin";
            int yas = 36;

            Kurs kurs1;
            kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Murat Bektaş";
            kurs2.IzlenmeOrani = 74;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Flutter";
            kurs3.Egitmen = "İlknur Yıldız";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.IzlenmeOrani); 
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var a in kurslar)
            {
                Console.WriteLine(a.KursAdi + " " + a.Egitmen + " " + a.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}