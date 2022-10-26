namespace Traveler.Models.Tipos; 

public class Genero {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsHombre { get; set; }
    public bool EsMujer { get; set; }
    public bool EsOtro { get; set; }
    
    public static List<Genero> DefaultValues(ApplicationDbContext db) {
        return new List<Genero>{
            new(){ Nombre = "Hombre", EsHombre = true},
            new(){ Nombre = "Mujer", EsMujer = true},
            new(){ Nombre = "Prefiero no decirlo", EsOtro = true}
        };
    }
    
}