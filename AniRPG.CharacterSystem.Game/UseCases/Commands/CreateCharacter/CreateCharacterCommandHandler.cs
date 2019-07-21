using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AniRPG.CharacterSystem.Domain.Entities;
using AniRPG.CharacterSystem.Game.Repositories;
using AniRPG.CharacterSystem.Game.Exceptions;

namespace AniRPG.CharacterSystem.Game.UseCases.Commands.CreateCharacter
{
    public class CreateCharacterCommandHandler : IRequestHandler<CreateCharacterCommand, Character>
    {       
        private readonly ICharacterSystemRepository _characterRepository;

        public CreateCharacterCommandHandler(ICharacterSystemRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<Character> Handle(CreateCharacterCommand request, CancellationToken cancellationToken)
        {
            if (await _characterRepository.CharacterExistsWithName(request.Name))
                throw new CharacterNameAlreadyExistsException(request.Name);

            var character = new Character()
            {             
                Name = request.Name
            };

            await _characterRepository.AddCharacter(character);

            return character;
        }
    }
}
