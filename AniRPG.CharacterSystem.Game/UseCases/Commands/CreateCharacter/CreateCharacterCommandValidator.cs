using FluentValidation;
using AniRPG.CharacterSystem.Game.Constants;

namespace AniRPG.CharacterSystem.Game.UseCases.Commands.CreateCharacter
{
    public class CreateCharacterCommandValidator : AbstractValidator<CreateCharacterCommand>
    {
        public CreateCharacterCommandValidator()
        {
            RuleFor(x => x.Name)
                .MaximumLength(CharacterConstants.NameMaxLength)
                .MinimumLength(CharacterConstants.NameMinLength);
        }
    }
}