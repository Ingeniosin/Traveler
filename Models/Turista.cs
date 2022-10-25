using System.ComponentModel.DataAnnotations;

namespace Traveler.Models; 

public class Turista {
    public int Id { get; set; }
    
    [Required]
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    
    [Required]
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    
    
    
}