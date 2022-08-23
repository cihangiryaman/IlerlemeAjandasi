using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.Entities.Logging.DatabaseLogging
{
    public class DatabaseLogger : ILogger
    {
        IlerlemeAjandasiLogContext _context;
        public void Log(string errorCode, string errorMessage, int userId, string? managerName = null)
        {
            using (_context = new IlerlemeAjandasiLogContext())
            {
                Error error = new Error();
                error.UserId = userId;
                error.ManagerName = managerName == null ? string.Empty : managerName;
                error.Date = DateTime.Now;
                error.FkerrorCodeId = GetErrorCodeByErrorCode(errorCode).Id;
                _context.Errors.Add(error);
                _context.SaveChanges();
            }
        }

        public ErrorCode GetErrorCodeByErrorCode(string errorCode)
        {
            using (_context = new IlerlemeAjandasiLogContext())
            {
                ErrorCode _errorCode = new ErrorCode();
                _errorCode = _context.ErrorCodes.Where(e => e.ErrorCode1 == errorCode).FirstOrDefault();
                return _errorCode;
            }
        }
    }
}
