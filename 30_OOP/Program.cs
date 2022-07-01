namespace _30_OOP
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi("Murat" , "Kurt");
            Ogrenci ogrenci = new Ogrenci("Larissa", "Çelik");
            Ogretmen ogretmen = new Ogretmen("Can", "Demirel");
            Console.WriteLine(kisi.TamAdi);
            Console.WriteLine(ogrenci.TamAdi);
            Console.WriteLine(ogretmen.TamAdi);
        }
    }
}