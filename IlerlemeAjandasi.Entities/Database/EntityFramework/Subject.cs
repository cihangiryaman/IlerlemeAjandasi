using System;
using System.Collections.Generic;
using IlerlemeAjandasi.Entities.Abstract;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class Subject : IEntity<Subject>
    {
        public Subject()
        {
            SubjectQuestions = new HashSet<SubjectQuestion>();
        }

        public int Id { get; set; }
        public int FklessonId { get; set; }
        public string SubjectName { get; set; } = null!;

        public virtual Lesson Fklesson { get; set; } = null!;
        public virtual ICollection<SubjectQuestion> SubjectQuestions { get; set; }
    }
}
