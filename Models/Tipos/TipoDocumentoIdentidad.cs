namespace Traveler.Models.Tipos;

public class TipoDocumentoIdentidad {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsRegistroCivil { get; set; }
    public bool EsTarjetaIdentidad { get; set; }
    public bool EsCedulaCiudadania { get; set; }
    public bool EsTarjetaExtranjeria { get; set; }
    public bool EsCedulaExtranjeria { get; set; }
    public bool EsPasaporte { get; set; }

    public static List<TipoDocumentoIdentidad> DefaultValues(ApplicationDbContext db) {
        return new List<TipoDocumentoIdentidad>{
            new(){ Nombre = "Registro Civil", EsRegistroCivil = true },
            new(){ Nombre = "Tarjeta de Identidad", EsTarjetaIdentidad = true },
            new(){ Nombre = "Cédula de Ciudadanía", EsCedulaCiudadania = true },
            new(){ Nombre = "Tarjeta de Extranjería", EsTarjetaExtranjeria = true },
            new(){ Nombre = "Cédula de Extranjería", EsCedulaExtranjeria = true },
            new(){ Nombre = "Pasaporte", EsPasaporte = true }
        };
    }
}