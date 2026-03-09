namespace AbstractFactory.Characters;

public class HumanCharacter : ICharacter
{
    public ITalent? Talent { get; set; }

    public void UseTalent()
    {
        Talent?.Use();
    }
}