using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); 
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Adi+": "+urun.Fiyati+"- "+urun.Aciklama);  //Foreach içine yazılan "urun" adlı değişkeni her bir elemanı için kullanır. yani for'un i si gibi.
            }

            Console.WriteLine("-------METOTLAR--------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Ayılar Yer", 12, 10);
            sepetManager.Ekle2("Elma", "Elmaların Elması", 15, 9);
            sepetManager.Ekle2("Kiraz", "Kirazını Yerim", 100, 2);
            
        }
    }
}

// Clean Code - Best Practice