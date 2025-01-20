
class Program()
{
    static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        //sayi1 ?  30 olurdu

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar2[0] ? 999 olurdu


        //int, decimal, float, double , bool.. değer tiplerdir.
        //array, class, interface bunlar referanstiplerdir.

        /*STACK -> değer tipler burada çalışıyor. HEAP -> referans tipler burada çalışıyor DİYE BELLEKTE YERLER VAR.
        --stack--          --heap--
          sayi1             
          sayi2 

          sayilar1 -----> 101/ [10,20,30]
          sayilar2 -----> 102/ [100,200,300]
        */

        //değişiklik



    }
}