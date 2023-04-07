namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Array - Dizi
            Birden fazla aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelerimizdir.
            Eğer; Index was outside the bounds of the array. Hatası alıyorsanız;
            Bilin ki dizinin boyutlarını aşacak şekilde eleman ekleme çabasındasınız.
            Hata nerede diye bakma, eleman ekleme işlemlerine git! */

            // İki dizi tanımlama tipi vardır.
            // 1- veritipi [] diziadi = new veritipi [elemansayisi];
            // 2- veritipi [] diziadi = {..........};

            int[] sayilar = new int[10];
            int[] yaslar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // yaslar dizisini ekrana basmak için;
            // for (int i = 0; i< yaslar.Length; i++)
            // {
            //    Console.WriteLine(yaslar[i]);
            // }

            // Rasgele sayı oluşturmak için Random classı oluşturuyoruz.
            Random random = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(100);
                Console.WriteLine(sayilar[i]);
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    Console.WriteLine("Çift sayılar: " + sayilar[i]);
                }
                else
                {
                    Console.WriteLine("Tek sayılar: " + sayilar[i]);
                }
            }
            Console.ReadKey();
        }
    }
}