namespace Decorator.Guns;

public class LaserSilencedGun
{
    public void Shoot()
    {
        Console.Write("使用镭射瞄准");
        Console.Write("静音");
        Console.WriteLine("射击");
    }
}