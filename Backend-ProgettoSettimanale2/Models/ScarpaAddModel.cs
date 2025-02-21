using System.ComponentModel.DataAnnotations;

namespace Backend_ProgettoSettimanale2.Models
{
    public class ScarpaAddModel
    {
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Il campo Marca è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il campo Marca deve contenere al massimo 50 caratteri")]
        public string? Marca { get; set; }

        [Display(Name = "Modello")]
        [Required(ErrorMessage = "Il campo Modello è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il campo Modello deve contenere al massimo 50 caratteri")]
        public string? Modello { get; set; }

        [Display(Name = "Prezzo")]
        [Required(ErrorMessage = "Il campo Prezzo è obbligatorio")]
        [Range(1, 1000, ErrorMessage = "Il campo Prezzo deve essere compreso tra 1 e 1000")]
        public decimal Prezzo { get; set; }

        [Display(Name = "Descrizione")]
        [Required(ErrorMessage = "Il campo Descrizione è obbligatorio")]
        [StringLength(500, ErrorMessage = "Il campo Descrizione deve contenere al massimo 500 caratteri")]
        public string? Descrizione { get; set; }

        [Display(Name = "UrlCopertina")]
        [Required(ErrorMessage = "Il campo Url Copertina è obbligatorio")]
        public string? UrlCopertina { get; set; }

        [Display(Name = "InputUrl")]
        [Required(ErrorMessage = "Il campo Url Immagine è obbligatorio")]
        public string? InputUrl { get; set; }
        public List<Immagine> Immagini { get; set; }
    }
}
