using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.ValidationRules
{
    public class AdminValidation : AbstractValidator<Admin>
    {
        public AdminValidation() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Isim boş geçilemez!");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad boş geçilemez!");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Adres boş geçilemez!");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez!");
            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.Birth).NotEmpty().WithMessage("Doğum tarihi boş geçilemez!");

            RuleFor(x => x)
            .Must(admin => admin.PassWord != admin.Birth.ToString("yyyyMMdd"))
            .WithMessage("Şifreniz doğum tarihi ile aynı olamaz!");

           
        }
    }
}
