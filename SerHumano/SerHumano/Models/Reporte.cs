using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerHumano.Models
{
    public class Reporte
    {
        public int ID{ get; set; }
        public string Ubicacion{ get; set; }
        public string CausaReporte { get; set; }
        public DateTime FechaReporte{ get; set; }
    }
}