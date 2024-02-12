using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._0___S.Solucion
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;

        public OrderService(
            IOrderRepository orderRepository,
            INotificationService notificationService,
            IInvoiceService invoiceService,
            ILoggerService loggerService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
                
        }

        public void SaveOrder(Order order)
        {
            try
            {
                ///Quitamos la responsabilidad de persistir la info
                _orderRepository.InsertOrder(order);

                ///Quitamos la responsabilidad de crear una factura
                var invoice = _invoiceService.CreateInvoice(order);

                ///Quitamos la responsabilidad de enviar el correo
                _notificationService.EmailInvoice(invoice);

                //Quitamos la responsabilidad de manejar los Logs
                _loggerService.Info("The Order was created");
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex.Message, ex);
            }
        }


    }
}
