namespace Decorator.Guns;

public class SilencedGun : IGun
{
    public void Shoot()
    {
        Console.Write("静音");
        Console.WriteLine("射击");
    }
}