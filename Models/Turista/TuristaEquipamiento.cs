namespace Traveler.Models.Turista; 

public class TuristaEquipamiento {
    public int Id { get; set; }
    
    public virtual Turista Turista { get; set; }
    public int TuristaId { get; set; }
    
    public string Detalle { get; set; }
}