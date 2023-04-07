namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Dongusu
            //int sayac=0;

            //while (sayac<=10) 
            //{
            //    sayac++;
            //    Console.WriteLine("Deneme");
            //}
            #endregion

            #region Do While Dongusu
            int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Sayı: "+sayac);
            //    sayac++;
            //}
            //while (sayac<=10); 
            #endregion

            #region For Dongusu
            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("Sayı: "+i);
            //}
            //Console.ReadKey();
            #endregion

            #region Carpim Tablosu
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            #endregion
        }
    }
}