﻿using SerHumano.Models;
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

        ReportListViewModel AsViewModel(Reporte Reporte)
        {
            return new ReportListViewModel() { Header = Reporte.CausaReporte, Id = Reporte.ID };
        }
    }
}