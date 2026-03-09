using AbstractFactory.Characters;
using AbstractFactory.Talents;

namespace AbstractFactory.Factories;

public class OrcFactory : ICharacterFactory
{
    public ITalent CreateTalent()
    {
        return new OrcTalent();
    }

    public ICharacter CreateCharacter()
    {
        return new OrcCharacter();
    }
}