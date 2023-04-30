namespace TestCGI1_v._2
{

    public class Artikel
    {
        public int ArtikelNummer { get; set; }
        public int StyckPris { get; set; }
        public string Namn { get; set; }


        public Artikel(int artikelNummer, int styckPris, string namn)
        {
            ArtikelNummer = artikelNummer;
            StyckPris = styckPris;
            Namn = namn;

        }

    }

}
