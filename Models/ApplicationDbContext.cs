using DynamicApi.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Traveler.Models.Datos;
using Traveler.Models.Organizacion;
using Traveler.Models.Tipos;
using Traveler.Models.Turista;
using Traveler.Models.Turista.Contacto;
using Traveler.Models.Turista.MedioTransporte;

namespace Traveler.Models; 

public class ApplicationDbContext : DynamicContext{

    public ApplicationDbContext(DbContextOptions options) : base(options) {
    }
    
    public DbSet<DatosPersonales> DatosPersonales { get; set; }
    public DbSet<TuristaUbicacion> Ubicaciones { get; set; }
    public DbSet<Organizacion.Organizacion> Organizaciones { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<MedioTransporte> MediosTransporte { get; set; }
    public DbSet<MotivoViaje> MotivosViaje { get; set; }
    public DbSet<TipoDocumentoIdentidad> TiposDocumentoIdentidad { get; set; }
    public DbSet<TipoOrganizacion> TiposOrganizacion { get; set; }
    public DbSet<Turista.Turista> Turistas { get; set; }
    public DbSet<TuristaEquipamiento> TuristasEquipamiento { get; set; }
    public DbSet<TuristaMedioTransporteCiudad> TuristasMediosTransporteCiudad { get; set; }
    public DbSet<TuristaMedioTransporteLlegada> TuristasMediosTransporteLlegada { get; set; }

    public DbSet<TipoTelefono> TiposTelefono { get; set; }
    public DbSet<TuristaCorreo> TuristasCorreos { get; set; }
    public DbSet<TuristaTelefono> TuristasTelefonos { get; set; }
    
}