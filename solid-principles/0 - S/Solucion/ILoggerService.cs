using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._0___S.Solucion
{
    public interface ILoggerService
    {
        public void Info(string message);
        public void Debug(string message);
        public void Error(string message, Exception exception);
    }
}
