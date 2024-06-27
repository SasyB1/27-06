using _27_06.Classi;
using _27_06.Services.Interface;
namespace _27_06.Services
{
    public class VenditeService : IVenditeService
    {
        private static readonly List<Vendita> _vendite = [];

        private readonly ISaleService _saleService;

        public VenditeService(ISaleService saleService)
        {
            _saleService = saleService;
        }

        public void AddVendita(Vendita vendita)
        {
            var lastId = _vendite.Select(x => x.Id).DefaultIfEmpty(0).Max();
            vendita.Id = lastId + 1;
            _vendite.Add(vendita);
        }

        public IEnumerable<Vendita> GetVendite() => _vendite;

        public IEnumerable<Statistiche> GetStatistiches() => 
            _saleService.GetSale().Select(s => new Statistiche
            {
                sala = s,
                BigliettiNormaliVenduti = _vendite.Where(p => p.Sala.Equals(s) && p.Biglietto.Tipo == TipoBiglietto.Normale).Count(),
                BigliettiRidottiVenduti = _vendite.Where(p => p.Sala.Equals(s) && p.Biglietto.Tipo == TipoBiglietto.Ridotto).Count(),

            });
       

    }
}
