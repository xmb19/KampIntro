using OOP3;

class Program()
{
    static void Main(string[] args)
    {
        // İnterfaceler de o inteface i implemente eden classın referansını tutabilir.
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService(); 
        ILoggerService fileLoggerService = new FileLoggerService();
        
        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);


        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);  


    }
}