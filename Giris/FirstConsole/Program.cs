namespace FirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("Birinci sayıyı giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplam: " + (s1 + s2));
            Console.ReadKey();
        }
    }
}