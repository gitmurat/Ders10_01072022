namespace _40_OOP
{
    class Hayvan
    {
        public string Tur { get; set; }
        public string Ses { get; set; }

        public Hayvan()
        {
            Console.WriteLine("Hayvan Yaratıldı.");
        }

        public void Bagir()
        {
            Console.WriteLine(Tur + ">>" + Ses.ToUpper());
        }
    }

    class Kedi : Hayvan                         //Hayvan is the "base class" of the class Kedi. any change in base                                                class effects all derived classes
    {
        public Kedi()
        {
            Tur = "Kedi";
            Ses = "Miyav";
            Console.WriteLine("Kedi Yaratıldı.");
        }
    }
    class Kopek : Hayvan
    {
        public Kopek()
        {
            Tur = "Kopek";
            Ses = "Hav hav";
            Console.WriteLine("Kopek Yaratıldı.");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Kedi kedi = new Kedi();                     //While creating class Kedi, the base class Hayvan is                                                    automatically created on it's own
            Console.WriteLine("-----------------------------");

            Kopek kopek = new Kopek();

            kedi.Bagir();
            kopek.Bagir();
        }
    }
}