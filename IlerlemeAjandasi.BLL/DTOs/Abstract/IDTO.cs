using FluentValidation.Results;
using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.DTOs.Abstract
{
    public interface IDTO<T> where T : class, IEntity<T>, new()
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<T> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
    }
}
