using IlerlemeAjandasi.BLL.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IlerlemeAjandasi.Entities.Logging.DatabaseLogging;

namespace IlerlemeAjandasi.BLL.Logging.Concrete.DatabaseLogging
{
    public class DatabaseLoggerBLL : ILogger
    {
        public void Log(string errorCode, string errorMessage, int userId)
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log(errorCode, errorMessage, userId);    
        }
    }
}
