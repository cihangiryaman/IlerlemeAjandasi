using FluentValidation.Results;
using IlerlemeAjandasi.BLL.Abstract;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using IlerlemeAjandasi.BLL.Validation.FluentValidation;
using IlerlemeAjandasi.Entities.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Concrete
{
    public class QuestionManager : IManager<Question>
    {
        Repository<Exam> _examRepo;
        Repository<SubjectQuestion> _subjectQuestionRepo;
        Repository<Question> _questionRepo;
        SubjectManager _subjectManager;
        QuestionValidator _questionValidator;
        public QuestionDTO questionDTO { get; set; }
        public SubjectQuestionDTO subjectQuestionDTO { get; set; }

        public QuestionManager()
        {
            questionDTO = new QuestionDTO();
            subjectQuestionDTO = new SubjectQuestionDTO();
            _questionRepo = new Repository<Question>();
            _subjectQuestionRepo = new Repository<SubjectQuestion>();
            _subjectManager = new SubjectManager();
            _examRepo = new Repository<Exam>();
            _questionValidator = new QuestionValidator();
        }
        public IEnumerable<Question> GetByExpression(Expression<Func<Question,bool>> expression)
        {
            IEnumerable<Question> questions = _questionRepo.GetByExpression(expression);
            return questions;
        }
        public IEnumerable<Question> GetAll()
        {
            IEnumerable<Question> questions = _questionRepo.GetAll();
            return questions;
        }
        public IEnumerable<Question> GetByUserId(int userId)
        {
            List<Question> questions = new List<Question>();
            Exam exam;
            foreach (Question question in questionDTO.AllEntities)
            {
                exam = _examRepo.GetById(question.FkexamId);
                if (exam.FkuserId == userId)
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        public IEnumerable<Question> GetByExamId(int examId)
        {
            List<Question> questions = new List<Question>();
            foreach (Question question in questionDTO.AllEntities)
            {
                if (question.FkexamId == examId)
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        public IEnumerable<Question> GetByExamDate(DateTime date)
        {
            List<Question> questions = new List<Question>();
            Exam exam;
            foreach (Question question in questionDTO.AllEntities)
            {
                exam = _examRepo.GetById(question.FkexamId);
                if (exam.Date == date.Date)
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        public IEnumerable<Question> GetBySubjectId(int subjectId)
        {
            List<Question> questions = new List<Question>();
            List<SubjectQuestion> subjectQuestions = _subjectQuestionRepo.GetByExpression(q => q.FksubjectId == subjectId).ToList();
            List<int> questionIds = new List<int>();
            foreach (SubjectQuestion subjectQuestion in subjectQuestions)
            {
                questionIds.Add(subjectQuestion.FkquestionId);
            }
            foreach (Question question in questionDTO.AllEntities)
            {
                if (questionIds.Contains(question.Id))
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        public IEnumerable<Question> GetByLessonId(int lessonId)
        {
            List<Question> questions = new List<Question>();
            List<Subject> subjects = _subjectManager.GetByLessonId(lessonId).ToList();
            List<int> questionIds = new List<int>();
            foreach (Subject subject in subjects)
            {
                foreach (SubjectQuestion subjectQuestion in subjectQuestionDTO.AllEntities)
                {
                    if (subjectQuestion.FksubjectId == subject.Id)
                    {
                        questionIds.Add(subjectQuestion.FkquestionId);
                    }
                }
            }
            foreach (Question question in questionDTO.AllEntities)
            {
                if (questionIds.Contains(question.Id))
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        public void Insert(int examId)
        {
            Question question = new Question
            {
                FkexamId = examId
            };
            ValidationResult result = _questionValidator.Validate(question);
            if (result.IsValid)
            {
                _questionRepo.Insert(question);
                _questionRepo.SaveChanges();
                questionDTO.Id = question.Id;
                questionDTO.FkexamId = question.FkexamId;
            }
            else
            {
                questionDTO.Errors.AddRange(result.Errors);
            }
            questionDTO.IsValid = result.IsValid;
        }
        public void Delete(int questionId)
        {
            _questionRepo.Delete(questionId);
            _questionRepo.SaveChanges();
        }
        public void Update(int questionId, int examId)
        {
            Question question = new Question
            {
                Id = questionId,
                FkexamId = examId
            };
            _questionRepo.Update(question);
            _questionRepo.SaveChanges();
        }
    }
}