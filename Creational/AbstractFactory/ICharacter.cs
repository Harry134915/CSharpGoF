namespace AbstractFactory;

public interface ICharacter
{
    public void UseTalent();
    ITalent? Talent { get; set; }
}