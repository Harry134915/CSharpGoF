namespace SimpleFactory.Weapons;

public class DefaultWeapon : IWeapon
{
    public void Use()
    {
        Console.WriteLine("徒手攻击!");
    }
}