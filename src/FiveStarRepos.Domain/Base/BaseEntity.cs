using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiveStarRepos.Domain.Base
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public abstract bool Validar();

        [NotMapped]
        public bool IsValid { get; private set; }

        [NotMapped]
        public ValidationResult ValidationResult { get; private set; }

        public void AddValidationResult(string propriedade, string mensagem)
        {
            var validacao = new ValidationResult();
            validacao.Errors.Add(new ValidationFailure(propriedade, mensagem));
            IsValid = false;
            ValidationResult = validacao;
        }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return IsValid = ValidationResult.IsValid;
        }
    }
}
