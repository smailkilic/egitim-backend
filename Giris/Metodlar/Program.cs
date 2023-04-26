using MyLibrary;
namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int toplam = 0;
            toplam = Topla(3, 5);
            Console.WriteLine($"Toplam: {toplam}");
            decimal sonuc = Bol(5, 3);
            Console.WriteLine($"Bölme: {sonuc}"); */

            Console.WriteLine(MyLib.Topla(3, 5));
            Console.WriteLine(MyLib.Cikar(10, 5));
        }

        /* // Toplama Metodu 2 adet integer parametre alıp geriye integer tipinden bir sonuç döner.
        static int Topla(int a, int b)
        {
            int toplam = a + b;
            return toplam;
        }

        static float Topla(float a, float b) // Değişken tipi farklı olduğu için aynı parametreleri verebilirim.
        {
            return a + b;
        }

        static decimal Topla(params decimal[] sayilar) // Girilen kadar tüm parametreyi toplamak için dizi yaptım.
        {
            decimal toplam = 0;
            for (int i = 0;i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        static int Cikar(int a, int b)
        {
            return (a - b);
        }

        static int Carp(int a, int b)
        {
            return (a * b);
        }

        static decimal Bol(int a, int b) // b = 0 olmamalı. Hata verir.
        {
            if (b == 0)
            {
                return 0;
            }
            return a / (decimal)b;
        } */
    }
}