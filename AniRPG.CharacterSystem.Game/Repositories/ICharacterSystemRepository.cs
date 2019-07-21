using System.Threading.Tasks;
using AniRPG.CharacterSystem.Domain.Entities;

namespace AniRPG.CharacterSystem.Game.Repositories
{
    public interface ICharacterSystemRepository
    {
        Task AddCharacter(Character character);
        Task<bool> CharacterExistsWithName(string name);
    }
}
