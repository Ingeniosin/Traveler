using Traveler.Models.Tipos;

namespace Traveler.Models.Organizacion; 

public class Organizacion {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public virtual TipoOrganizacion TipoOrganizacion { get; set; }
    
    public static List<Organizacion> DefaultValues(ApplicationDbContext db) {
        return new List<Organizacion>{
            new(){Nombre = "Preview", TipoOrganizacion = db.TiposOrganizacion.First(x => x.EsOtro)},
        };
    }
    
}