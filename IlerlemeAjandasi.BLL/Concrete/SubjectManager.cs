using FluentValidation.Results;
using IlerlemeAjandasi.BLL.Abstract;
using IlerlemeAjandasi.BLL.DTOs.Abstract;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using IlerlemeAjandasi.BLL.Validation.FluentValidation;
using IlerlemeAjandasi.Entities.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Concrete
{
    public class SubjectManager : IManager<Subject>
    {
        public SubjectDTO subjectDTO;
        Repository<Subject> _subjectRepo;
        SubjectValidator _subjectValidator;

        public SubjectManager()
        {
            subjectDTO = new SubjectDTO();
            _subjectRepo = new Repository<Subject>();
            _subjectValidator = new SubjectValidator();
        }
        public IEnumerable<Subject> GetByLessonId(int lessonId)
        {
            List<Subject> subjects = new List<Subject>();
            foreach (Subject subject in subjectDTO.AllEntities)
            {
                if (subject.FklessonId == lessonId)
                {
                    subjects.Add(subject);
                }
            }
            return subjects;
        }
        public void Insert(int lessonId, string subjectName)
        {
            Subject subject = new Subject
            {
                FklessonId = lessonId,
                SubjectName = subjectName
            };
            ValidationResult result = _subjectValidator.Validate(subject);
            if (result.IsValid)
            {
                _subjectRepo.Insert(subject);
                _subjectRepo.SaveChanges();
                subjectDTO.SubjectName = subject.SubjectName;
                subjectDTO.Id = subject.Id;
                subjectDTO.FKLessonId = subject.FklessonId;
            }
            else
            {
                subjectDTO.Errors.AddRange(result.Errors);
            }
            subjectDTO.IsValid = result.IsValid;
        }
    }
}
