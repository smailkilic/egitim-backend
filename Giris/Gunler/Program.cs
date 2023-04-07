namespace Gunler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            string gun = "";
            Console.WriteLine("1-7 arasında sayı giriniz.");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    gun = "Pazartesi";
                    break;
                case 2:
                    gun = "Salı";
                    break;
                case 3:
                    gun = "Çarşamba";
                    break;
                case 4:
                    gun = "Perşembe";
                    break;
                case 5:
                    gun = "Cuma";
                    break;
                case 6:
                    gun = "Cumartesi";
                    break;
                case 7:
                    gun = "Pazar";
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    break;
            }
            Console.WriteLine("Girilen gün: " + gun);
            Console.ReadKey();
        }
    }
}