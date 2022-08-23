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
    public class SubjectDTO : IDTO<Subject>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<Subject> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
        public string SubjectName { get; set; } = null!;
        public int FKLessonId { get; set; }

        public SubjectDTO()
        {
            Repository<Subject> subjectRepo = new Repository<Subject>();
            AllEntities = subjectRepo.GetAll().ToList();
            Errors = new List<ValidationFailure>();
        }
    }
}
