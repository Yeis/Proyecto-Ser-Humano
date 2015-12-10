using SerHumano.Business;
using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult SubmitReport(Models.Reporte reporte, HttpPostedFileBase file)
        {
            string folderPath = "Images";
            string filePath = null;
            if (file != null)
            {
                filePath = folderPath + "\\" + file.FileName;

                string longPathFolder = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, folderPath);
                string longPath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, filePath);
                bool exists = Directory.Exists(longPathFolder);
                if (!exists)
                    Directory.CreateDirectory(longPathFolder);
                file.SaveAs(longPath);
            }
            reporte.FechaReporte = DateTime.Now;
            reporte.FilePath = filePath;
            reporteBusiness.Insert(reporte);
            return RedirectToAction("Index", "Home");
        }
    }
}