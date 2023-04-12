namespace Diziler
{
    struct Ogrenci // 4 Değişkeni tek bir yapıda yani Ogrenci içinde topladım.
    {
        public string Ad, Soyad, tcNo; // Public demediğim sürece alt bloklardan buraya erişemem.
        public DateTime dogumTarihi;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler Giris
            /* array - dizi
            birden fazla aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelerimizdir.
            eğer; ındex was outside the bounds of the array. hatası alıyorsanız;
            bilin ki dizinin boyutlarını aşacak şekilde eleman ekleme çabasındasınız.
            hata nerede diye bakma, eleman ekleme işlemlerine git!

            iki dizi tanımlama tipi vardır.
             1 - veritipi[] diziadi = new veritipi[elemansayisi];
            2 - veritipi[] diziadi = { ..........};

            int[] sayilar = new int[10];
            int[] yaslar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            yaslar dizisini ekrana basmak için;
            for (int i = 0; i < yaslar.length; i++)
            {
                console.writeline(yaslar[i]);
            }

            rasgele sayı oluşturmak için random classı oluşturuyoruz.
           random random = new random();

            for (int i = 0; i < sayilar.length; i++)
            {
                sayilar[i] = random.next(100);
                console.writeline(sayilar[i]);
            }

            for (int i = 0; i < sayilar.length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    console.writeline("çift sayılar: " + sayilar[i]);
                }
                else
                {
                    console.writeline("tek sayılar: " + sayilar[i]);
                }
            }
            Console.readkey(); */
            #endregion

            #region Array Sinifi
            /* // Microsoft tarafından geliştirilen hazır metodların olduğu bir sınıftır.
            // Sınıf içerisinde dizileri sıralamaya, boyutunu değiştirmeye yarayan hazır metodlar vardır.

            int[] sayilar = { 1, 2, 9, 8, 5, 6, 12, 56, 11, 3 };
            int[] sayilar2 = { 0, 0, 0 };

            Array.Sort(sayilar); // Diziyi sıralar.
            // Array.Clear(sayilar); // Diziyi sıfırlar.

            Array.Copy(sayilar, sayilar2, 3);

            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            } */
            #endregion

            #region Listeler

            #region Tanımlama
            /* // Aynı T tipinden veri tiplerini bir arada tutan ve dinamik olarak artan bir dizi yapısıdır.
            // Örnek List<T> T: Type'ın kısaltılmışıdır.
            List<int> sayilar = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(random.Next(100));
            }
            // Ekrana Bastırılması
            // İndisi bilinen verinin basılması
            //Console.WriteLine(sayilar[2]);
            
            // Hem for hem foreach ile tüm elemanları yazdırma.
            for (int i = 0; i < sayilar.Count; i++) // sayilar.Length listelerde çalışmaz.
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("---Sıralanmış Hali---");
            
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            } */
            #endregion

            #region Sınıf bilgisi tutma

            #region Eski usül öğrenci tanımlaması
            /* // Öğrenci isimleri için liste
            List<string> isimler = new List<string>();
            // Soyisimler için
            List<string> soyisimler = new List<string>();
            // Yaş için
            List<DateTime> dogumGunleri = new List<DateTime>();

            isimler.Add("Özlem");
            isimler.Add("Mustafa");
            isimler.Add("İsmail");
            soyisimler.Add("Argun");
            soyisimler.Add("Çeliktaş");
            soyisimler.Add("Kılıç");
            dogumGunleri.Add(new DateTime(1995, 5, 9)); // Yıl, ay, gün şeklinde DateTime yazılır.
            dogumGunleri.Add(new DateTime(1991, 4, 9));
            dogumGunleri.Add(new DateTime(2000, 10, 21)); */
            #endregion

            #region Yeni usül öğrenci tanımlaması (struct)
            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                dogumTarihi = new DateTime (1990, 1, 1),
                tcNo = "12345678901"
            });
            Ogrenci veli = new Ogrenci();
            veli.Ad = "Veli";
            veli.Soyad = "Kaya";
            veli.dogumTarihi = new DateTime(2000, 1, 1);
            veli.tcNo = "123";

            ogrenciler.Add(veli);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad);
            }
            #endregion
            #endregion

            #endregion
        }
    }
}