namespace Decorator.Decorators;

public abstract class GunDecorator : IGun
{
    protected IGun Gun;

    public GunDecorator(IGun gun)
    {
        Gun = gun;
    }

    public virtual void Shoot()
    {
        Gun.Shoot();
    }
}