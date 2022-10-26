namespace Traveler.Models.Turista.Contacto; 

public class TuristaCorreo {
    public int Id { get; set; }
    public string Email { get; set; }
    public virtual Models.Turista.Turista Turista { get; set; }
    public int TuristaId { get; set; }
}