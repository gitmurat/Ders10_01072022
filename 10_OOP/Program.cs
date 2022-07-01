namespace _10_OOP
{
    class Daire
    {
        private double _Yaricap;

        public double Yaricap
        {
            get { return _Yaricap; }
            set
            {
                if (value <= 0)
                {
                    _Yaricap = 1;
                }
                else
                {
                    _Yaricap = value;
                }
            }
        }

        public void Hakkinda()
        {
            Console.WriteLine("Daire: ");
            Console.WriteLine("Yarıçap = " + Yaricap);
            Console.WriteLine("Alan = " + AlanHesapla());
        }

        public double AlanHesapla()
            { return _Yaricap*_Yaricap*3.14; }

        public Daire(double yaricap)
        {
            Yaricap = yaricap;
            Console.WriteLine("Daire Yaratıldı");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire(22.4);
            //daire.YariCap = 10;
            daire.Hakkinda();
        }
    }
}