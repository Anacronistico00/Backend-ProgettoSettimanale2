namespace Backend_ProgettoSettimanale2.Models
{
    public class Scarpa
    {
        public Guid Id { get; set; }
        public string? Marca { get; set; }
        public string? Modello { get; set; }
        public decimal? Prezzo { get; set; }
        public string? Descrizione { get; set; }
        public string? UrlCopertina { get; set; }
        public string? InputUrl { get; set; }
        public List<Immagine>? Immagini { get; set; }
    }
}
