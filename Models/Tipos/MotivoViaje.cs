namespace Traveler.Models.Tipos;

public class MotivoViaje {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool EsTrabajo { get; set; }
    public bool EsEstudio { get; set; }
    public bool EsTurismo { get; set; }
    public bool EsOtro { get; set; }

    public static List<MotivoViaje> DefaultValues(ApplicationDbContext db) {
        return new List<MotivoViaje>{
            new(){Nombre = "Trabajo", EsTrabajo = true},
            new(){Nombre = "Estudio", EsEstudio = true},
            new(){Nombre = "Turismo", EsTurismo = true},
            new(){Nombre = "Otro", EsOtro = true}
        };
    }

}