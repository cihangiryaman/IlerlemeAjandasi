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
    public class LessonDTO : IDTO<Lesson>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<Lesson> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
        public string LessonName { get; set; }

        public LessonDTO()
        {
            Repository<Lesson> lessonRepo = new Repository<Lesson>();
            AllEntities = lessonRepo.GetAll().ToList();
            Errors = new List<ValidationFailure>();
        }
    }
}
