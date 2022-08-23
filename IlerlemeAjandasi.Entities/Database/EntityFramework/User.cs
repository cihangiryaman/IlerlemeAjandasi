using System;
using System.Collections.Generic;
using IlerlemeAjandasi.Entities.Abstract;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class User : IEntity<User>
    {
        public User()
        {
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string NickName { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Question> Questions { get; set; }
    }
}
