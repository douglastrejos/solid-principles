using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._0___S.Solucion
{
    public class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            return true;
        }
    }
}
