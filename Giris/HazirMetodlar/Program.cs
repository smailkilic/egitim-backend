using System.Diagnostics;

namespace HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matematik Hazır Metodlar
            /* // Pi sayısı
            Console.WriteLine(Math.PI);
            // Yuvarlama
            decimal sayi = 12.1m;
            float sayi2 = 12.8f;
            Console.WriteLine(decimal.Ceiling(sayi)); // Verilen sayıyı yukarı yuvarlar.
            Console.WriteLine(decimal.Round(sayi)); // Verilen sayıyı aşağı yuvarlar.
            Console.WriteLine(float.Ceiling(sayi2)); // Sonuç 13
            Console.WriteLine(float.Round(sayi2));
            // Üs Alma
            Console.WriteLine(Math.Pow(2,4)); // 2'nin 4.kuvvetini al. Sonuç 16 verecek.
            // Karekök Alma
            Console.WriteLine(Math.Sqrt(16)); // Sonuç 4 verecek. */

            #region try-catch

            /* try
            {
                Console.WriteLine(sayi2/0);
                Console.WriteLine(decimal.Parse("ali"));
            }
            catch (FormatException ex) // 'ex' adında variable oluşturdum.
            {
                Console.WriteLine("Format hatası oluştu!: " + ex.Message);
            }
            catch (DivideByZeroException ex) // 0'a bölme hatası.
            {
                Console.WriteLine("Sıfıra bölme hatası oluştu!");
            }
            catch (Exception ex) // Exception: oluşabilecek tüm hataları içine alır.
            {
                Console.WriteLine("Hata oluştu!: " + ex.Message);
            } */
            #endregion

            #endregion

            #region String Hazır Metodlar
            string haber = "Uyuşturucu   ticareti    suçundan     kırmızı bültenle aranan ve 24 yıl kesinleşmiş hapis cezası bulunan suç örgütü lideri Urfi Çetinkaya dün akşam İstanbul'da yakalandı. Çetinkaya, adliyedeki işlemlerinin tamamlanmasının ardından cezaevine gönderilirken operasyona dair yeni ayrıntılar da ortaya çıktı.";

            #region Split, Trim
            //Trim: string ifadedeki başında ve sonunda olan boşlukları atar.
            //var temizcumle = haber.Trim();
            //Console.WriteLine(temizcumle);
            
            //// Cumle Sayisi 

            //var cumleler = haber.Split('.');
            //foreach (var cumle in cumleler)
            //{
            //    var yenicumle = cumle.Replace("Urfi", "****")
            //                       .Replace("Çetinkaya", "*********"); // Urfi Çetinkaya olan yerleri * yapar.

            //    Console.WriteLine(yenicumle);
            //    var kelimeler = cumle.Split(' ');
            //    //foreach (var kelime in kelimeler)
            //    //{
            //    //    Console.WriteLine(kelime);
            //    //}
            //}
            #endregion

            #region Substring, IndexOf
            string haber2 = "operasyona dair yeni ayrıntılar da ortaya çıktı.";
            //Console.WriteLine(haber2.Substring(10)); // 10. index'ten itibaren alır. Öncesini keser.
            //Console.WriteLine(haber2.Substring(11, 4));// "dair" kelimesini alır.
            //var index = haber2.IndexOf("dair");
            //Console.WriteLine(string.Join("", haber2.Reverse())); // Reverse string.Join ile kullanılır.
            //Console.WriteLine(haber2.Substring(index, 4)); //dair
            //Console.WriteLine(haber2.ToUpper()); // Cümleyi büyük harflerle yazar.
            //Console.WriteLine(haber2.ToLowerInvariant()); // Cümleyi küçük harflerle yazar.
            //Console.WriteLine(haber2.Contains("yeni"));

            #endregion

            #endregion

            #region DateTime
            // Bulunduğun zamanı verir.
            /* Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            DateTime dogumGunu = new DateTime(2000, 10, 21);
            DateTime suan = DateTime.Now;
            TimeSpan zamanFarki = suan - dogumGunu;
            Console.WriteLine("Toplam Geçen Saat: " +zamanFarki.TotalHours);
            Console.WriteLine("Toplam Geçen Gün: " +zamanFarki.TotalDays); */

            #endregion
        }
    }
}