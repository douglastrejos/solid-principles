using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._0___S.Problema
{
    internal class OrdenService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                ///Tiene la responsabilidad de persistir la info, si debemos cambiar ese proceso debemos venir aqui
                this.InsertOrder(order);

                ///Tiene la responsabilidad de crear una factura, si debemos cambiar ese proceso debemos venir aqui
                var invoice = this.CreateInvoice(order);

                ///Tiene la responsabilidad de enviar el correo, si debemos cambiar ese proceso debemos venir aqui
                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The Order was created");
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.Message);
            }

        }

        private void EmailInvoice(Invoice invoice)
        {
        }

        public bool InsertOrder(Order order)
        {
            return true;
        }

        public Invoice CreateInvoice(Order order) 
        { 
            return new Invoice();
        }

    }

    public class Order
    {

    }

    public class Invoice
    {

    }

}
