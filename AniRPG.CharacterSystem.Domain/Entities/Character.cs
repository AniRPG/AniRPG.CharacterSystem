using AniRPG.Core.Domain;

namespace AniRPG.CharacterSystem.Domain.Entities
{
    public class Character : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
