namespace Po1450_AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string nazev, string cestaObrazek, int width) 
        { 
            Nazev = nazev;
            CestaObrazek = cestaObrazek;
            AktualniPozice = -1;
            Width = width;
        }
        public string Nazev { get; private set; }
        public string CestaObrazek { get; private set; }
        private List<Souradnice> PoziceSeznam { get; set; } = new List<Souradnice>();
        private int AktualniPozice { get; set; }
        public int Width { get; set; }
        private bool JduDopredu { get; set; } = true;
        private bool HlavaVPravo { get; set; } = true;
        public string Style
        {
            get
            {
                if (AktualniPozice < 0)
                    return $" width: {Width}px;";
                else
                {
                    var poz = PoziceSeznam[AktualniPozice];
                    return poz.Style + $" width: {Width*poz.VelikostObrazku/100}px;";
                }
            }
        }
        public string TransformRotateY => HlavaVPravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
        
        public void PridejPozici(int pozX, int pozY, int velikostObrazku)
        {
            var souradnice = new Souradnice(pozX, pozY, velikostObrazku);
            PoziceSeznam.Add(souradnice);
        }

        public void Presun()
        {
            if (JduDopredu)
            {
                if (AktualniPozice + 1 == PoziceSeznam.Count)
                {
                    JduDopredu = false;
                }
                
            }
            else
            {
                //jdu zpet
                if (AktualniPozice == 0)
                {
                    JduDopredu = true;
                }
            }
            var predchoziPozice = AktualniPozice;

            if (JduDopredu)
                AktualniPozice++;
            else
                AktualniPozice--;

            HlavaVPravo = predchoziPozice<0 || PoziceSeznam[predchoziPozice].PozX < PoziceSeznam[AktualniPozice].PozX;
        }
    }
}
