using MediatR;
using AniRPG.CharacterSystem.Domain.Entities;

namespace AniRPG.CharacterSystem.Game.UseCases.Commands.CreateCharacter
{
    public class CreateCharacterCommand : IRequest<Character>
    {
        public string Name { get; set; }
    }
}
