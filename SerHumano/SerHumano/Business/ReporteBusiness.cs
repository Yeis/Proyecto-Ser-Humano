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
    }
}