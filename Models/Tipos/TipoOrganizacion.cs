namespace Traveler.Models.Tipos; 

public class TipoOrganizacion {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsHotel { get; set; }
    public bool EsAgencia { get; set; }
    public bool EsHostal { get; set; }
    public bool EsRestaurante { get; set; }
    public bool EsOtro { get; set; }
    
    public static List<TipoOrganizacion> DefaultValues(ApplicationDbContext db) {
        return new List<TipoOrganizacion>{
            new(){ Nombre = "Hotel", EsHotel = true },
            new(){ Nombre = "Agencia", EsAgencia = true },
            new(){ Nombre = "Hostal", EsHostal = true },
            new(){ Nombre = "Restaurante", EsRestaurante = true },
            new(){ Nombre = "Otro", EsOtro = true }
        };
    }
    
    
}