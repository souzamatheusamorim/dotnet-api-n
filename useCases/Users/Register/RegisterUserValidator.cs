using FluentValidation;
using Library.Communication.Requests;

namespace nwl.useCases.Users.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("É necessário preencher o campo nome.");
            RuleFor(request => request.Email).NotEmpty().WithMessage("É necessário preencher o campo email.");
            RuleFor(request => request.Password).NotEmpty().WithMessage("É necessário preencher o campo senha.");
            When(request => string.IsNullOrEmpty(request.Password) == false, () =>
            {
                RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("A senha deve possuir seis ou mais caracteres");
            });
            

            
        }
    }
}
