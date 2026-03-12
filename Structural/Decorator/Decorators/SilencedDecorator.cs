namespace Decorator.Decorators;

public class SilencedDecorator : GunDecorator
{
    public SilencedDecorator(IGun gun) : base(gun)
    {
    }

    public override void Shoot()
    {
        Console.Write("静音");
        base.Shoot();
    }
}