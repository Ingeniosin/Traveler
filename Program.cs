using DynamicApi;
using Traveler.Models;
using Traveler.Services;

var builder = WebApplication.CreateBuilder(args);

new DynamicApi<ApplicationDbContext>(routeBuilder => routeBuilder
        .addNonService(x => x.DatosPersonales)
        .addNonService(x => x.Ubicaciones)
        .addNonService(x => x.Roles)
        .addNonService(x => x.Usuarios)
        .addNonService(x => x.Generos)
        .addNonService(x => x.MediosTransporte)
        .addNonService(x => x.MotivosViaje)
        .addNonService(x => x.TiposDocumentoIdentidad)
        .addNonService(x => x.TiposOrganizacion)
        .addNonService(x => x.Turistas)
        .addNonService(x => x.TuristasEquipamiento)
        .addNonService(x => x.TuristasMediosTransporteCiudad)
        .addNonService(x => x.TuristasMediosTransporteLlegada)
        .addNonService(x => x.Organizaciones)
        .addNonService(x => x.TiposTelefono)
        .addNonService(x => x.TuristasCorreos)
        .addNonService(x => x.TuristasTelefonos)
        .addAction<GetChartOfInput, GetChartOf>("GetChartOf", true)
, builder).Start();