namespace _27_06.Classi
{
    public class Statistiche
    {
        public required Sale sala { get; set; }

        public int BigliettiNormaliVenduti { get; set; }

        public int BigliettiRidottiVenduti { get; set; }

        public int BigliettiTotaliVenduti => BigliettiNormaliVenduti + BigliettiRidottiVenduti;

        public decimal BigliettiPercentuale => BigliettiTotaliVenduti / sala.Posti * 100;
    }
}
