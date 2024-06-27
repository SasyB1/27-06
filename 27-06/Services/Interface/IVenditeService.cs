using _27_06.Classi;

namespace _27_06.Services.Interface
{
    public interface IVenditeService 
    {
        IEnumerable<Vendita> GetVendite();

        void AddVendita(Vendita vendita);

        IEnumerable<Statistiche>GetStatistiches();

    }
}
