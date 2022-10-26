using Traveler.Models.Datos;
using Traveler.Models.Tipos;
using Traveler.Models.Turista.Contacto;
using Traveler.Models.Turista.MedioTransporte;

namespace Traveler.Models.Turista; 

public class Turista {
    public int Id { get; set; }
    public virtual DatosPersonales DatosPersonales { get; set; }
    public int DatosPersonalesId { get; set; }
    
    public virtual TuristaUbicacion Origen { get; set; }
    public int OrigenId { get; set; }
    
    public virtual TuristaUbicacion Destino { get; set; }
    public int DestinoId { get; set; }
    
    public virtual List<TuristaMedioTransporteLlegada> MediosTransporteLlegada { get; set; }
    public virtual List<TuristaMedioTransporteCiudad> MediosTransporteCiudad { get; set; }
    
    public bool LlegoEnGrupo { get; set; }
    public int? CantidadPersonasGrupo { get; set; }
    
    public DateTime FechaLlegada { get; set; }
    public DateTime FechaSalida { get; set; }
    
    public int CantidadDias => (FechaSalida - FechaLlegada).Days;
    
    public decimal Presupuesto { get; set; }
    
    public virtual List<TuristaEquipamiento> Equipamiento { get; set; }
    
    public virtual List<TuristaTelefono> Telefonos { get; set; }
    public virtual List<TuristaCorreo> Correos { get; set; }

    public virtual MotivoViaje MotivoViaje { get; set; }
    public int MotivoViajeId { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

}