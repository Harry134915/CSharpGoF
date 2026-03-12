namespace Decorator.Guns;

internal class LaserGun : IGun
{
    public void Shoot()
    {
        Console.Write("使用镭射瞄准");
        Console.WriteLine("射击");
    }
}