using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Logging.Abstract
{
    public interface ILogger
    {
        void Log(string errorCode, string errorMessage, int userId);
    }
}
