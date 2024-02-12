using solid_principles._0___S.Solucion;
using solid_principles._1___O.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._1___O.Solucion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService(new ReportGeneratorPdf());

            service.GenerateReport(orders);
        }
    }
}
