using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.Entities.Abstract
{
    public interface ILogger
    {
        void Log(string errorCode, string errorMessage, int userId, string? managerName = null);
    }
}
