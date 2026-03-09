namespace SimpleFactory.Weapons;

public class Bow : IWeapon
{
    public void Use()
    {
        Console.WriteLine("射箭攻击!");
    }
}