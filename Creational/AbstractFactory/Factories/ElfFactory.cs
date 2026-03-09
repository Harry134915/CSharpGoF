using AbstractFactory.Characters;
using AbstractFactory.Talents;

namespace AbstractFactory.Factories;

public class ElfFactory : ICharacterFactory
{
    public ITalent CreateTalent()
    {
        return new ElfTalent();
    }

    public ICharacter CreateCharacter()
    {
        return new ElfCharacter();
    }
}