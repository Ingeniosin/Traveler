namespace Traveler.Models.Organizacion; 

public class Rol {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool PermisosAdministrador { get; set; }
    public bool PermisosOperador { get; set; }
    
    public static List<Rol> DefaultValues(ApplicationDbContext db) {
        return new List<Rol>{
            new(){ Nombre = "Administrador", PermisosAdministrador = true, PermisosOperador = true },
            new(){ Nombre = "Operador", PermisosAdministrador = false, PermisosOperador = true },
        };
    }
    
}