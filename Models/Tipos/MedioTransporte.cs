namespace Traveler.Models.Tipos; 

public class MedioTransporte {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsAutoParticular { get; set; }
    public bool EsTaxi { get; set; }
    public bool EsColectivo { get; set; }
    public bool EsBus { get; set; }
    public bool EsTren { get; set; }
    public bool EsAvion { get; set; }
    public bool EsBarco { get; set; }
    public bool EsBicicleta { get; set; }
    public bool EsMoto { get; set; }
    public bool EsOtro { get; set; }
    
    public bool EsLlegada { get; set; }
    public bool EsCiudad { get; set; }
    
    public static List<MedioTransporte> DefaultValues(ApplicationDbContext db) {
        return new List<MedioTransporte>{
            new(){Nombre = "Auto Particular", EsAutoParticular = true, EsLlegada = true, EsCiudad = true},
            new(){Nombre = "Taxi", EsTaxi = true, EsLlegada = true, EsCiudad = true},
            new(){Nombre = "Colectivo", EsColectivo = true, EsLlegada = true, EsCiudad = false},
            new(){Nombre = "Bus", EsBus = true, EsLlegada = true, EsCiudad = true},
            new(){Nombre = "Tren", EsTren = true, EsLlegada = true, EsCiudad = false},
            new(){Nombre = "Avión", EsAvion = true, EsLlegada = true, EsCiudad = false},
            new(){Nombre = "Barco", EsBarco = true, EsLlegada = true, EsCiudad = false},
            new(){Nombre = "Bicicleta", EsBicicleta = true, EsLlegada = true, EsCiudad = true},
            new(){Nombre = "Moto", EsMoto = true, EsLlegada = true, EsCiudad = true},
            new(){Nombre = "Otro", EsOtro = true, EsLlegada = true, EsCiudad = true},

        };
    }
    
}