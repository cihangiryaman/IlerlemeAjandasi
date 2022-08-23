using IlerlemeAjandasi.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class Exam : IEntity<Exam>
    {
        public Exam()
        {
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public int FkuserId { get; set; }
        public string? FkexamPlaceId { get; set; }
        public string? ExamBrand { get; set; }
        public string? TotalNet { get; set; }
        public short? Rank { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
