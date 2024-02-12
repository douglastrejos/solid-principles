using solid_principles._0___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._1___O.Solucion
{
    internal interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
