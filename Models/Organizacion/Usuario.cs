using Traveler.Models.Datos;

namespace Traveler.Models.Organizacion; 

public class Usuario {
    public int Id { get; set; }
    
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public bool EsActivo { get; set; }
    
    public virtual Rol Rol { get; set; }
    public int RolId { get; set; }
    
    public virtual DatosPersonales DatosPersonales { get; set; }
    public int DatosPersonalesId { get; set; }
    
    public DateTime UltimoAcceso { get; set; } = DateTime.Now;
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
}