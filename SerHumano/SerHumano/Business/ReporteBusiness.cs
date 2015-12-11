using SerHumano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerHumano.Business
{
    public class ReporteBusiness
    {
        ReporteContext context = new ReporteContext();

        public ReporteBusiness()
        {

        }

        public void Insert(Reporte report)
        {
            context.Reportes.Add(report);
            context.SaveChanges();
        }

        public ICollection<ReportListViewModel> GetReportsList()
        {
            var ViewModels = context.Reportes.Select(AsViewModel);
            return ViewModels.ToList();
        }

        public Reporte GetReportById(int Id)
        {
            var Report = context.Reportes.Where(r => r.ID == Id).SingleOrDefault();
            return Report;
        }

        ReportListViewModel AsViewModel(Reporte Reporte)
        {
            return new ReportListViewModel() { Header = Reporte.Titulo, Id = Reporte.ID };
        }
    }
}