using FluentValidation;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Validation.FluentValidation
{
    public class SubjectValidator : AbstractValidator<Subject>
    {
        LessonDTO _lessonDTO;

        public SubjectValidator()
        {
            _lessonDTO = new LessonDTO();
            List<int> lessonIds = new List<int>();
            foreach (Lesson lesson in _lessonDTO.AllEntities)
            {
                lessonIds.Add(lesson.Id);
            }
            RuleFor(s => s.FklessonId)
                .NotNull().WithMessage("Lütfen hangi dersin konusu olduğunu seçiniz").WithErrorCode("SULE001")
                .Must(lesId => lessonIds.Contains(lesId)).WithMessage("Böyle bir ders bulunamadı").WithErrorCode("SULE002");
            RuleFor(s => s.SubjectName)
                .NotNull().WithMessage("Lütfen konunun ismini giriniz").WithErrorCode("SUNA001")
                .MaximumLength(150).WithMessage("Konunun ismi 150 karakterden uzun olamaz").WithErrorCode("SUNA002")
                .MinimumLength(3).WithMessage("Konunun ismi 3 karakterden kısa olamaz").WithErrorCode("SUNA003");
        }
    }
}
