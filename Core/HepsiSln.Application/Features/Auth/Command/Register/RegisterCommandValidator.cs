using FluentValidation;

namespace HepsiSln.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator:AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().MaximumLength(50).MinimumLength(2).WithName("isim soyisim");
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).MinimumLength(5).WithName("E-posta adresi").EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).WithName("Şifre");
            RuleFor(x => x.ConfimPassword).NotEmpty().MinimumLength(8).WithName("Şifre Tekrarı").Equal(x=>x.Password);
        }
    }
}
