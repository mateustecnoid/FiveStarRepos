using FiveStarRepos.Domain.Resources;
using FluentValidation;

namespace FiveStarRepos.Domain.Validators
{
    public class DonoValidation : AbstractValidator<Dono>
    {
        public DonoValidation()
        {
            RuleFor(x => x.Login).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                 .MaximumLength(100).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.Url).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia);

            RuleFor(x => x.AvatarUrl).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia);

            RuleFor(x => x.Tipo).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                .MaximumLength(100).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);
        }
    }
}
