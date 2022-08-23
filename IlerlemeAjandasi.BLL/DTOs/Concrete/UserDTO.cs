using FluentValidation.Results;
using IlerlemeAjandasi.BLL.DTOs.Abstract;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.DTOs.Concrete
{
    public class UserDTO : IDTO<User>
    {
        public List<ValidationFailure> Errors { get; set; }
        public List<User> AllEntities { get; set; }
        public bool IsValid { get; set; }
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }

        public UserDTO()
        {
            Repository<User> _userRepo = new Repository<User>();
            AllEntities = _userRepo.GetAll().ToList();
            Errors = new List<ValidationFailure>();
        }
    }
}
