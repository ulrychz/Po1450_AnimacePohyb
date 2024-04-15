using Po1450_AnimacePohyb.Models;

namespace Po1450_AnimacePohyb.Pages
{
    public partial class Animace1
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }
        public Postava Postava { get; set; }

        private void InicializaceHry()
        {
            Postava = new Postava(nazev: "Maxipes", cestaObrazek: "../img/maxipes.png");
            Postava.PridejPozici(pozX: 45, pozY: 280);
            Postava.PridejPozici(pozX: 480, pozY: 240);
            Postava.PridejPozici(pozX: 840, pozY: 340);
            Postava.PridejPozici(pozX: 110, pozY: 470);
        }
    }
}
