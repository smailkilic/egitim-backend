namespace SuyunSicakligi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sicaklik;
            Console.Write("Suyun sıcaklığını giriniz: ");
            sicaklik = Convert.ToInt32(Console.ReadLine());
            if (sicaklik > 0 && sicaklik < 100)
            {
                Console.WriteLine("Sıvı");
            }
            else
            {
                if (sicaklik <= 0)
                {
                    Console.WriteLine("Buz");
                }
                else
                {
                    if (sicaklik >= 100)
                    {
                        Console.WriteLine("Gaz");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}