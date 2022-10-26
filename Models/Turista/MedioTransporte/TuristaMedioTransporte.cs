namespace Traveler.Models.Turista.MedioTransporte; 

public abstract class TuristaMedioTransporte {
    public int Id { get; set; }
    
    public virtual Turista Turista { get; set; }
    public int TuristaId { get; set; }
    
    public virtual Tipos.MedioTransporte MedioTransporte { get; set; }
    public int MedioTransporteId { get; set; }

}