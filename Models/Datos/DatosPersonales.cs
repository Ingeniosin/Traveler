using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Traveler.Models.Tipos;

namespace Traveler.Models.Datos; 

public class DatosPersonales {
    public int Id { get; set; }
 
    [Required]
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    
    [Required]
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    
    public string NombreCompleto => string.Join(" ", new[] { PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido }.ToList().Where(x => !string.IsNullOrEmpty(x)));
    
    public virtual TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }
    public int TipoDocumentoIdentidadId { get; set; }
    
    public string Identificacion { get; set; }
    
    public DateTime FechaNacimiento { get; set; }
    
    public virtual Genero Genero { get; set; }
    public int GeneroId { get; set; }
}