using System;
using System.Collections.Generic;
using IlerlemeAjandasi.Entities.Abstract;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class SubjectQuestion : IEntity<SubjectQuestion>
    {
        public int Id { get; set; }
        public int FkquestionId { get; set; }
        public int FksubjectId { get; set; }

        public virtual Question Fkquestion { get; set; } = null!;
        public virtual Subject Fksubject { get; set; } = null!;
    }
}
