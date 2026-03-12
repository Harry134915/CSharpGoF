using Decorator.Decorators;
using Decorator.Guns;

namespace Decorator;

/// <summary>
/// 装饰器模式 (Decorator Pattern)
/// 一种 结构设计模式 不修改原有类的情况下，动态地给对象增加功能。
///
/// 核心思想:
/// 把对象“包一层”，在这一层里增加行为。
///
/// 注意:
/// 装饰器模式避免了类因为不同的组合导致的类数量爆炸
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用简单工厂模式
        UnusedDesignPattern();

        //使用简单工厂模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        //玩家捡到一把枪, 进行射击
        var gun = new Gun();
        gun.Shoot();

        //玩家捡到一把带消音器的枪, 进行射击
        var silencedGun = new SilencedGun();
        silencedGun.Shoot();

        //玩家捡到一把带激光瞄准的枪
        var laserGun = new LaserGun();
        laserGun.Shoot();

        //玩家想将消音器和laser同时安装到一把枪上, 但是并不行, 除非你造一把新叫做LaserSilencedGun的枪
        var laserSilencedGun = new LaserSilencedGun();
        laserSilencedGun.Shoot();

        //但是如果你想要更多的组合, 那么你就需要造更多的枪了, 这显然不是一个好办法
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用装饰模式的代码:");

        //玩家捡到一把枪, 进行射击
        var gun = new Gun();
        gun.Shoot();

        //玩家捡到一把带消音器的枪, 进行射击
        var gun2 = new Gun();
        var silencedDecorator = new SilencedDecorator(gun2);
        silencedDecorator.Shoot();

        //玩家捡到一把带激光瞄准的枪
        var gun3 = new Gun();
        var laserDecorator = new LaserDecorator(gun3);
        laserDecorator.Shoot();

        //玩家想将消音器和laser同时安装到一把枪上
        var laserSilencedGun = new LaserDecorator(new SilencedDecorator(gun));
        laserSilencedGun.Shoot();

        //如果你想要更多的组合, 那么你只需要包更多的装饰就可以, 避免了类因为不同的组合导致的类数量爆炸, 这就是装饰模式的优点
    }
}