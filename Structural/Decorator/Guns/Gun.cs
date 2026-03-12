namespace Decorator.Guns;

public class Gun : IGun
{
    public void Shoot()
    {
        Console.WriteLine("射击");
    }
}