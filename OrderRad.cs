namespace TestCGI1_v._2
{

    public class OrderRad
    {
        public int RadNummer { get; set; }
        public int Antal { get; set; }
        public Order Order { get; set; }
        public Artikel Artikel { get; set; }
        public decimal TotalPris => Antal * Artikel.StyckPris;
        public OrderRad(int radNummer, int antal, Artikel artikel)
        {
            RadNummer = radNummer;
            Antal = antal;
            Artikel = artikel;
        }



    }
}
