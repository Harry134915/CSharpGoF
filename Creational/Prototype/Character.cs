namespace Prototype;

public class Character
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }

    public void Attack()
    {
        Console.WriteLine($"{Name}发起攻击, 造成{Damage}伤害");
    }

    public Character Clone()
    {
        return new Character
        {
            Name = Name,
            Damage = Damage,
            Defense = Defense
        };
    }
}