using FluentValidation;
using FluentValidation.Results;
using IlerlemeAjandasi.BLL.Abstract;
using IlerlemeAjandasi.BLL.DTOs.Concrete;
using IlerlemeAjandasi.BLL.Validation.FluentValidation;
using IlerlemeAjandasi.Entities.Concrete;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Concrete
{
    public class UserManager : IManager<User>
    {
        Repository<User> _userRepo;
        public UserDTO UserDTO { get; set; }
        UserValidator _userValidator;

        public UserManager()
        {
            UserDTO = new UserDTO();
            _userRepo = new Repository<User>();
            _userValidator = new UserValidator();
        }
        public void Login(string nickName,string password)
        {            
            UserValidator validator = new UserValidator(nickName, password);
            ValidationResult result = new ValidationResult();
            List<User> users = _userRepo.GetAll().ToList();
            foreach (User user in users)
            {
                result = validator.Validate(user);
                if (result.IsValid)
                {
                    UserDTO.Id = user.Id;
                    UserDTO.NickName = user.NickName;
                    UserDTO.Password = user.Password;
                    break;
                }               
            }
            if (!result.IsValid)
            {               
                UserDTO.Errors.AddRange(result.Errors);
            }
            UserDTO.IsValid = result.IsValid;
        }
        public void Register(string nickName, string password, string confirmPassword)
        {
            UserValidator validator = new UserValidator(confirmPassword);
            ValidationResult result;
            User newUser = new User();
            newUser.NickName = nickName;
            newUser.Password = password;
            result = validator.Validate(newUser);
            if (result.IsValid)
            {
                _userRepo.Insert(newUser);
                _userRepo.SaveChanges();
                UserDTO.Id = newUser.Id;
                UserDTO.NickName = newUser.NickName;
                UserDTO.Password = newUser.Password;
            }
            else
            {
                UserDTO.Errors.AddRange(result.Errors);
            }
            UserDTO.IsValid = result.IsValid;
        }
        public void Update(int userId, string nickName, string password, string confirmPassword)
        {
            _userValidator = new UserValidator(confirmPassword);
            User user = new User
            {
                Id = userId,
                NickName = nickName,
                Password = password
            };
            ValidationResult result = _userValidator.Validate(user);
            if (result.IsValid)
            {
                _userRepo.Update(user);
                _userRepo.SaveChanges();
                UserDTO.Id = user.Id;
                UserDTO.NickName = user.NickName;
                UserDTO.Password = user.Password;
            }
            else
            {
                UserDTO.Errors.AddRange(result.Errors);
            }
            UserDTO.IsValid = result.IsValid;
        }
        public void Delete(int userId)
        {

        }
    }
}
