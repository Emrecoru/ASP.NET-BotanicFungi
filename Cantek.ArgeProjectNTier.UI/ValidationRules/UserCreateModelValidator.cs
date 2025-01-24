using Cantek.ArgeProjectNTier.UI.Models;
using FluentValidation;

namespace Cantek.ArgeProjectNTier.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz!");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola minimum 3 karakter içermelidir.");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolalar eşleşmiyor.");
            RuleFor(x => x.Password).Must(ContainsSequentialNumbers).WithMessage("Parola ardışık 3 sayı içeremez")
                .When(x => x.Password != null && x.ConfirmPassword != null);
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı minimum 3 karakter olmalıdır.");
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur.");
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad boş olamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş olamaz").EmailAddress().WithMessage("Email doğru değil.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş olamaz.");
        }
        static bool ContainsSequentialNumbers(string password)
        {

            for (int i = 0; i <= password.Length - 3; i++)
            {
                bool isSequential = true;
                for (int j = 0; j < 2; j++)
                {
                    if (password[i + j + 1] - password[i + j] != 1)
                    {
                        isSequential = false;
                        break;
                    }
                }

                if (isSequential)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
