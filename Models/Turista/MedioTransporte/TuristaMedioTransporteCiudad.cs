using Microsoft.EntityFrameworkCore;

namespace Traveler.Models.Turista.MedioTransporte; 

[Index(nameof(TuristaId), nameof(MedioTransporteId), IsUnique = true)]
public class TuristaMedioTransporteCiudad : TuristaMedioTransporte{
    
}