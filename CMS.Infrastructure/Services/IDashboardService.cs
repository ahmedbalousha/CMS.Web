using CMS.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Services
{
    public interface IDashboardService
    {
        Task<DashboardViewModel> GetData();
        Task<List<PieChartViewModel>> GetUserTypeChart();

        Task<List<PieChartViewModel>> GetContentByMonthChart();
        Task<List<PieChartViewModel>> GetContentTypeChart();
        }
}
