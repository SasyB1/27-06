namespace _27_06.Classi
{
    public enum TipoBiglietto
    {
       Normale,
       Ridotto
    }
    public class Biglietto : ClassBase
    {
        public TipoBiglietto Tipo { get; set; }
    }
}
