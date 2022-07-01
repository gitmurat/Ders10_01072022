namespace _60_OOP_New_Operator
{
    class Kisi
    {
        public string Adi { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Kisi kisi1, kisi2;
            sayi1 = 5;
            kisi1 = new Kisi();
            kisi1.Adi = "Ahmet";

            sayi2 = sayi1;
            sayi2 = 10;

            kisi2 = new Kisi();
            kisi2.Adi = "Mehmet";

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(kisi1.Adi);
            Console.WriteLine(kisi2.Adi);
        }
    }
}