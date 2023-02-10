using FiveStarRepos.Domain.Resources;
using FluentValidation;

namespace FiveStarRepos.Domain.Validators
{
    public class RepositorioValidation : AbstractValidator<Repositorio>
    {
        public RepositorioValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                .MaximumLength(50).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.NomeCompleto).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                        .MaximumLength(150).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.Url).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia);

            RuleFor(x => x.Descricao).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                     .MaximumLength(500).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.DataCriacaoRepositorio).NotEqual(new System.DateTime()).WithMessage(ValidationResource.PropriedadeComDataInvalida);

            RuleFor(x => x.DataAtualizacaoRepositorio).NotEqual(new System.DateTime()).WithMessage(ValidationResource.PropriedadeComDataInvalida);

            RuleFor(x => x.Tamanho).GreaterThan(0).WithMessage(ValidationResource.PropriedadeValorInvalido);

            RuleFor(x => x.Stars).GreaterThan(0).WithMessage(ValidationResource.PropriedadeValorInvalido);

            RuleFor(x => x.Linguagem).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                     .MaximumLength(50).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.BranchPadrao).NotEmpty().WithMessage(ValidationResource.PropriedadeVazia)
                                        .MaximumLength(50).WithMessage(ValidationResource.PropriedadeExcedeuTamanhoMaximo);

            RuleFor(x => x.Dono).SetValidator(new DonoValidation()).When(y => y.Dono is not null);
            RuleFor(x => x.Licenca).SetValidator(new LicencaValidation()).When(y => y.Licenca is not null);

        }
    }
}
