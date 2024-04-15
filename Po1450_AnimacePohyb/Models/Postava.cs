namespace Po1450_AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string nazev, string cestaObrazek) 
        { 
            Nazev = nazev;
            CestaObrazek = cestaObrazek;
            AktualniPozice = 0;
        }
        public string Nazev { get; private set; }
        public string CestaObrazek { get; private set; }
        private List<Souradnice> Pozice { get; set; } = new List<Souradnice>();
        public int AktualniPozice { get; private set; }

        public string Style
        {
            get
            {
                return Pozice[AktualniPozice].Style;
            }
        }

        public void PridejPozici(int pozX, int pozY)
        {
            var souradnice = new Souradnice(pozX, pozY);
            Pozice.Add(souradnice);
        }
    }
}
