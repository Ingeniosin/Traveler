namespace Traveler.Models.Tipos; 

public class TipoTelefono {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsCelular { get; set; }
    public bool EsFijo { get; set; }
    
    public static List<TipoTelefono> DefaultValues(ApplicationDbContext db) {
        return new List<TipoTelefono>{
            new(){ Nombre = "Celular", EsCelular = true},
            new(){ Nombre = "Fijo", EsFijo = true},
        };
    }
    
}