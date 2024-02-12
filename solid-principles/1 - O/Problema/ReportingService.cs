using solid_principles._0___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._1___O.Problema
{
    internal class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                CreatePdfReport(orders);
            }
            if (type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }

            //SI EN UN FUTURO TUBIESEMOS QUE AGREGAR OTROS TIPOS DE REPORTE COMO JSON, XML
            //ESTA CLASE SE HARIA EXTENSA Y NO SERIA CODIGO LIMPIO
            //1. Modificar el enumerado
            //2. Agregar metodo para crear reporte de ese tipo

            if(type == ReportType.JSON)
            {
                CreateJsonReport(orders);
            }

        }        

        public void CreateExcelReport(List<Order> orders)
        {
            
        }
        public void CreatePdfReport(List<Order> orders)
        {
            
        }

        //Nuevo metodo para nuevo tipo de reporte
        private void CreateJsonReport(List<Order> orders)
        {
            
        }
    }

    public enum ReportType
    {
        EXCEL = 0,
        PDF = 1,
        JSON = 2,
    }

}
