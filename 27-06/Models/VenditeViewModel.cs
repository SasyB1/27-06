using _27_06.Classi;
using System.ComponentModel.DataAnnotations;
namespace _27_06.Models
{
    public class VenditeViewModel
    {
        
        public required IEnumerable<Sale> Sale { get; set; }

        [Display(Name = "Tipo di biglietto")]
        public TipoBiglietto Tipo { get; set; }

        [Display(Name = "Sala"), Required ]
        public int SalaId { get; set; }

        [Display(Name ="Nome dello spettatore"), Required]
        public string NomeSpettatore { get; set; }

        [Display(Name ="Cognome dello spettatore"), Required]
        public string CognomeSpettatore { get; set; }
    }
}
