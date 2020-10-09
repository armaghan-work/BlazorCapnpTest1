using Models.MonicaData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Services.MonicaCharts
{
    public interface IMonicaChartService
    {
        Task<string[]> GetExportedFilesAsync();

        Task<List<MonicaBaseData>> GetBaseDataAsync(string data);

        List<MonicaSerie> GetXAxises(MonicaBaseData monicaBaseData);

        List<MonicaSerie> GetSeries(MonicaBaseData monicaBaseData);
    }
}
