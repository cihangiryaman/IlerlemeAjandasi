using FluentValidation;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.BLL.Validation.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //Common Validation
            RuleFor(u => u.NickName)
                .NotNull().WithMessage("Kullanıcı adınızı giriniz").WithErrorCode("USNI007");
            RuleFor(u => u.Password)
                .NotNull().WithMessage("Şifrenizi giriniz").WithErrorCode("USPA006");
        }
        public UserValidator(string confirmPassword)
        {
            //Register Validation
            RuleFor(x => x.NickName)
                .NotNull().WithMessage("Kullanıcı adınızı giriniz").WithErrorCode("USNI001")
                .MinimumLength(4).WithMessage("Kullanıcı adınız 4 karakterden kısa olamaz").WithErrorCode("USNI004")
                .MaximumLength(25).WithMessage("Kullanıcı adınız 25 karakterden uzun olamaz").WithErrorCode("USNI005")
                .Must(nick => !nick.Contains('.') || !nick.Contains('/') || !nick.Contains('{') || !nick.Contains('#') || !nick.Contains('}') || !nick.Contains('+') || !nick.Contains(',') || !nick.Contains('(') || !nick.Contains(')')).WithMessage("Kullanıcı adınızda './{}()+,#?' karakterleri bulunamaz").WithErrorCode("USNI006");
            RuleFor(x => x.Password)
                .NotNull().WithMessage("Şifrenizi giriniz").WithErrorCode("USPA001")
                .Equal(confirmPassword).WithMessage("Şifreniz doğruladığınız şifreyle eşleşmiyor").WithErrorCode("USPA004")
                .MinimumLength(8).WithMessage("Şifreniz 8 karakterden kısa olamaz").WithErrorCode("USPA005");
        }
        public UserValidator(string nickName, string password)
        {
            //Login Validation
            RuleFor(x => x.NickName)
                .NotNull().WithMessage("Kullanıcı adınızı giriniz").WithErrorCode("USNI002")
                .Equal(nickName).WithMessage("Kullanıcı adı yanlış tekrar deneyiniz").WithErrorCode("USNI003");
            RuleFor(x => x.Password)
                .NotNull().WithMessage("Şifrenizi giriniz").WithErrorCode("USPA002")
                .Equal(password).WithMessage("Şifre yanlış tekrar deneyiniz").WithErrorCode("USPA003");
        }
    }
}
