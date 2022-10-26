using Traveler.Models.Tipos;

namespace Traveler.Models.Turista.Contacto; 

public class TuristaTelefono {
    public int Id { get; set; }
    public string Numero { get; set; }
    
    public virtual TipoTelefono TipoTelefono { get; set; }
    public int TipoTelefonoId { get; set; }
    
    public bool EsWhatsapp { get; set; }
    public bool EsLlamada { get; set; }
    public bool EsSms { get; set; }
    
    public bool EsPrincipal { get; set; }
    
    public virtual Models.Turista.Turista Turista { get; set; }
    public int TuristaId { get; set; }
}