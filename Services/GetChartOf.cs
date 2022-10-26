using System.Globalization;
using DynamicApi.Serializers;
using DynamicApi.Services;
using Microsoft.EntityFrameworkCore;
using Traveler.Models;

namespace Traveler.Services; 

public class GetChartOf :  IActionService<GetChartOfInput> {
    
    private ApplicationDbContext _context;

    public GetChartOf(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<object> OnQuery(GetChartOfInput input, HttpContext httpContext) {
        var turistas = await _context.Turistas.Include(x => x.Origen).ToListAsync();
        var chartName = input.ChartName.ToLower().Trim();

        if(chartName.Equals("ciudadorigen")) {
            var count = new Dictionary<string, int>();
            
            turistas.ForEach(x => {
                var ciudad = x.Origen.Ciudad.ToLower().Trim();
                if(count.ContainsKey(ciudad)) {
                    count[ciudad]++;
                } else {
                    count.Add(ciudad, 1);
                }
            });
            
            var data = new List<dynamic>();
            count.ToList().ForEach(x => {
                data.Add(new { name = x.Key, value = x.Value });
            });
            
            return data;
        } else if (chartName.Equals("cantidadtmes")) {
            var count = new Dictionary<string, int>();
            
            turistas.ForEach(x => {
                var mes = x.FechaCreacion.Month;
                var mesName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                
                if(count.ContainsKey(mesName)) {
                    count[mesName]++;
                } else {
                    count.Add(mesName, 1);
                }
            });
            
            var data = new List<dynamic>();
            count.ToList().ForEach(x => {
                data.Add(new { name = x.Key, value = x.Value });
            });
            return data;
        } else if(chartName.Equals("otrasestadisticas")) {
            var promGasto = turistas.Average(x => x.Presupuesto);
            var promEdad = turistas.Average(x => {
                var datosPersonalesFechaNacimiento = x.DatosPersonales.FechaNacimiento;
                var edad = DateTime.Now.Year-datosPersonalesFechaNacimiento.Year;
                if(DateTime.Now.Month < datosPersonalesFechaNacimiento.Month || (DateTime.Now.Month == datosPersonalesFechaNacimiento.Month && DateTime.Now.Day < datosPersonalesFechaNacimiento.Day)) {
                    edad--;
                }
                return edad;
            });
            
            var promDiasHospedado = turistas.Average(x => {
                var inicio = x.FechaLlegada;
                var fin = x.FechaSalida;
                var dias = (fin - inicio).TotalDays;
                return dias;
            });
            
            return new { promGasto, promEdad, promDiasHospedado };
        }

        return null;
        

    }

    public SerializeType SerializeType => SerializeType.STANDARD;
}

public class GetChartOfInput {
    
    public string ChartName { get; set; }
    
}