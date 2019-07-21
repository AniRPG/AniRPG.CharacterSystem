using System;

namespace AniRPG.CharacterSystem.Game.Exceptions
{
    public class CharacterNameAlreadyExistsException : Exception
    {
        public string CharacterName { get; }
        public CharacterNameAlreadyExistsException(string name) : 
            base($"Character with name {name} already exists")
        {
            CharacterName = name;
        }
    }
}
