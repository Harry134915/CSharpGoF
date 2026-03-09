namespace AbstractFactory;

public interface ICharacterFactory
{
    ITalent CreateTalent();
    ICharacter CreateCharacter();
}