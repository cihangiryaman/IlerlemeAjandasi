using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class Lesson : IEntity<Lesson>
    {
        public Lesson()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string LessonName { get; set; } = null!;

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
