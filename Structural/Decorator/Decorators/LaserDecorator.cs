namespace Decorator.Decorators;

public class LaserDecorator : GunDecorator
{
    public LaserDecorator(IGun gun) : base(gun)
    {
    }

    public override void Shoot()
    {
        Console.Write("使用镭射瞄准");
        base.Shoot();
    }
}