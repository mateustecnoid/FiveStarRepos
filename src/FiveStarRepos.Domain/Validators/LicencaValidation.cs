using FiveStarRepos.Domain.Resources;
using FluentValidation;

namespace FiveStarRepos.Domain.Validators
{
    public class LicencaValidation : AbstractValidator<Licenca>
    {
        public LicencaValidation()
        {
            RuleFor(x => x.Chave).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                 .MaximumLength(50).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.Nome).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                .MaximumLength(50).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.Url).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia);
        }
    }
}
