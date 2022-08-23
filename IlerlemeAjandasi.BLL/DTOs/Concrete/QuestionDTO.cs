using FluentValidation.Results;
using IlerlemeAjandasi.BLL.DTOs.Abstract;
using IlerlemeAjandasi.Entities.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;

namespace IlerlemeAjandasi.BLL.DTOs.Concrete
{
    public class QuestionDTO : IDTO<Question>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<Question> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
        public int FkexamId { get; set; }

        public QuestionDTO()
        {
            IRepository<Question> questionRepo = new Repository<Question>();
            Errors = new List<ValidationFailure>();
            AllEntities = questionRepo.GetAll().ToList();
        }
    }
}