using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager  // Manager, DAO, DTO, Service, Controller gibi şeyler varsa bunlar bir operasyon tutuyor demektir.
    {
        public void Ekle(Product urun) 
        {
            Console.WriteLine("TBRKLR Sepete Eklendi: " + urun.Adi);   
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }

    }

}
