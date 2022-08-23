using FluentValidation.Results;
using IlerlemeAjandasi.BLL.DTOs.Abstract;
using IlerlemeAjandasi.Entities.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.DTOs.Concrete
{
    public class SubjectQuestionDTO : IDTO<SubjectQuestion>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<SubjectQuestion> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
        public int FKQuestionId { get; set; }
        public int FKSubjectId { get; set; }

        public SubjectQuestionDTO()
        {
            IRepository<SubjectQuestion> _subjectQuestionRepo = new Repository<SubjectQuestion>();
            Errors = new List<ValidationFailure>();
            AllEntities = _subjectQuestionRepo.GetAll().ToList();
        }
    }
}
