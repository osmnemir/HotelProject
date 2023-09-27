using FluentValidation;
using WebUI.DTOs.GuestDto;

namespace WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilmez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilmez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilmez");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ad alanı en az 3 karekterli yapınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyad alanı en az 2 karekterli yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir alanı en az 3 karekterli yapınız");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Ad alanı en fazla 20 karekterli yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Soyad alanı en fazla 30 karekterli yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Şehir alanı en fazla 20 karekterli yapınız");
        }
    }
}
