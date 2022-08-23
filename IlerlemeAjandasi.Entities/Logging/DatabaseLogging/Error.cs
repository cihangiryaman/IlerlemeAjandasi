using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace IlerlemeAjandasi.Entities.Logging.DatabaseLogging
{
    public partial class Error
    {
        public int Id { get; set; }
        public int FkerrorCodeId { get; set; }
        public int UserId { get; set; }
        public string ManagerName { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual ErrorCode FkerrorCode { get; set; } = null!;
    }
}
