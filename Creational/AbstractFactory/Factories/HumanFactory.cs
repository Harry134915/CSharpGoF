using AbstractFactory.Characters;
using AbstractFactory.Talents;

namespace AbstractFactory.Factories;

public class HumanFactory : ICharacterFactory
{
    public ITalent CreateTalent()
    {
        return new HumanTalent();
    }

    public ICharacter CreateCharacter()
    {
        return new HumanCharacter();
    }
}