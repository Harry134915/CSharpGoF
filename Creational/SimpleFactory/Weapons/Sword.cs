namespace SimpleFactory.Weapons;

public class Sword : IWeapon
{
    public void Use()
    {
        Console.WriteLine("挥剑攻击!");
    }
}