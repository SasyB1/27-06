using _27_06.Classi;

namespace _27_06.Services
{
    public class SaleService
    {
        private static readonly List<Sale> _sale =
        [
            new Sale { Id = 1, Nome = "Sala Nord", Posti = 120 },
            new Sale { Id = 2, Nome = "Sala Sud", Posti = 120 },
            new Sale { Id = 3, Nome = "Sala Est", Posti = 120 },
        ];

        public List<Sale> GetSale() => _sale;
    }
}