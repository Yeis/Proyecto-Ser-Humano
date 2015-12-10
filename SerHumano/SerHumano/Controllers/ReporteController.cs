using SerHumano.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerHumano.Controllers
{
    public class ReporteController : Controller
    {

        ReporteBusiness reporteBusiness = new ReporteBusiness();
        // GET: Reporte
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReportsList()
        {
            var Reports = reporteBusiness.GetReportsList();
            return View(Reports);
        }

        public ActionResult SubmitReport()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitReport(Models.Reporte reporte)
        {
            reporte.FechaReporte = DateTime.Now;
            reporteBusiness.Insert(reporte);
            return RedirectToAction("Home", "Index");
        }
    }
}