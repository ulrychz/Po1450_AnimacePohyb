namespace Po1450_AnimacePohyb.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX, int pozY) 
        { 
            PozX = pozX;
            PozY = pozY;
        }
        private int PozX { get; set; }
        private int PozY { get; set;}

        public string Style => $"left: {PozX}px; top: {PozY}px;";
    }
}
