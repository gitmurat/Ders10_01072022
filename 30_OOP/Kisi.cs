namespace _30_OOP
{
    class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TamAdi
        {
            get
            {
                return Adi + " " + Soyadi.ToUpper();
            }
        }

        public Kisi(string Adi, string Soyadi)
        {
            this.Adi = Adi;
            this.Soyadi = Soyadi;
        }
    }
}