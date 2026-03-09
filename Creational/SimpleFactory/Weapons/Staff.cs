namespace SimpleFactory.Weapons;

public class Staff : IWeapon
{
    public void Use()
    {
        Console.WriteLine("发射魔法球!");
    }
}