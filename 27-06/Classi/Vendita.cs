namespace _27_06.Classi
{
    public class Vendita : ClassBase
    {
        public required Biglietto Biglietto { get; set; }

        public required Cliente Cliente { get; set; }

        public required Sale Sala { get; set; }
    }
}
