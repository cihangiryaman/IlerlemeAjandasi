using FluentValidation;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Validation.FluentValidation
{
    public class QuestionValidator : AbstractValidator<Question>
    {
        ExamDTO _examDTO;

        public QuestionValidator()
        {
            _examDTO = new ExamDTO();
            List<int> examIds = new List<int>();
            foreach (Exam exam in _examDTO.AllEntities)
            {
                examIds.Add(exam.Id);
            }
            RuleFor(q => q.FkexamId)
                .NotNull().WithMessage("Sorunun ekleneceği sınavı seçiniz").WithErrorCode("QUEX001")
                .Must(exId => examIds.Contains(exId)).WithMessage("Lütfen geçerli bir sınav seçin").WithErrorCode("QUEX002");
        }
    }
}
