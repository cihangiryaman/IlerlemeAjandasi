using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace IlerlemeAjandasi.Entities.Logging.DatabaseLogging
{
    public partial class ErrorCode
    {
        public ErrorCode()
        {
            Errors = new HashSet<Error>();
        }

        public int Id { get; set; }
        public string ErrorCode1 { get; set; } = null!;
        public string ErrorMessage { get; set; } = null!;

        public virtual ICollection<Error> Errors { get; set; }
    }
}
