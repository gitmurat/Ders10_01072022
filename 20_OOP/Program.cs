namespace _20_OOP
{
    class Madde
    {
        private string _Adi;
        /*public string Adi
        {
            get
            {
                return _Adi;
            }
            set
            {
                _Adi = value;
            }*/

        public string Adi { get; set; }
        public int  KaynamaNoktası { get; set; }
        public int ErimeNoktası { get; set; }
        public int Sicaklik { get; set; }

        public void Hakkında()
        { 
            Console.WriteLine(Adi);
            Console.WriteLine("-------------------------");
            Console.WriteLine(KaynamaNoktası + " " + ErimeNoktası);
            Console.WriteLine(HalGoster());
        }

        public string HalGoster()
        {
            if (Sicaklik < ErimeNoktası)
                return "Katı";
            else if (Sicaklik > ErimeNoktası && Sicaklik < KaynamaNoktası)
                return "Sıvı";
            else
                return "Gaz";
        }

        public Madde(string adi)

        {
            Adi = adi;
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
            Madde madde1 = new Madde("Su");
            Madde madde2 = new Madde("Demir");
            Madde madde3 = new Madde("Alkol");

            madde1.ErimeNoktası = 0;
            madde2.ErimeNoktası = 1587;
            madde3.ErimeNoktası = -20;
            madde1.KaynamaNoktası = 100;
            madde2.KaynamaNoktası = 5000;
            madde3.KaynamaNoktası = 80;

            madde1.Sicaklik = madde2.Sicaklik = madde3.Sicaklik = 125;

            madde1.Hakkında();
            madde2.Hakkında();
            madde3.Hakkında();

        }
        
    }
}