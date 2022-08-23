using FluentValidation.Results;
using IlerlemeAjandasi.BLL.DTOs.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.DTOs.Concrete
{
    public class ExamDTO : IDTO<Exam>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<Exam> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }

        public ExamDTO()
        {
            Errors = new List<ValidationFailure>();
            Repository<Exam> _examRepo = new Repository<Exam>();
            AllEntities = _examRepo.GetAll().ToList();
        }
    }
}
