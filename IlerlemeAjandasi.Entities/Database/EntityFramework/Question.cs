using System;
using System.Collections.Generic;
using IlerlemeAjandasi.Entities.Abstract;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class Question : IEntity<Question>
    {
        public Question()
        {
            SubjectQuestions = new HashSet<SubjectQuestion>();
        }

        public int Id { get; set; }
        public int FkexamId { get; set; }

        public virtual Exam Fkexam { get; set; } = null!;
        public virtual User FkexamNavigation { get; set; } = null!;
        public virtual ICollection<SubjectQuestion> SubjectQuestions { get; set; }
    }
}
