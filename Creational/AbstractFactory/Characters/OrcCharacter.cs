namespace AbstractFactory.Characters;

internal class OrcCharacter : ICharacter
{
    public ITalent? Talent { get; set; }

    public void UseTalent()
    {
        Talent?.Use();
    }
}