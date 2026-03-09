namespace AbstractFactory.Characters;

internal class ElfCharacter : ICharacter
{
    public ITalent? Talent { get; set; }

    public void UseTalent()
    {
        Talent?.Use();
    }
}