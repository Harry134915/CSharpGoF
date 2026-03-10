using FactoryMethod.Level;
using FactoryMethod.Unit;

namespace FactoryMethod;

/// <summary>
/// 工厂方法模式（Factory Method Pattern）
/// 是一种创建型设计模式
/// 
/// 核心思想:
/// 定义了一个接口用于创建对象，但由子类决定要实例化的类是哪一个。
///
/// 注意:
/// 工厂方法模式将对象的实例化推迟到子类中进行，从而实现了对象创建的灵活性和可扩展性。
/// 一个工厂只负责一类产品。
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

        Console.WriteLine("玩家游玩肉鸽游戏");

        Console.WriteLine("玩家进入了一个新的关卡。");
        var enemies = new List<IUnit>();
        var archer = new Archer();
        enemies.Add(archer);
        var archer2 = new Archer();
        enemies.Add(archer2);
        var archer3 = new Archer();
        enemies.Add(archer3);
        var archer4 = new Archer();
        enemies.Add(archer4);
        var archer5 = new Archer();
        enemies.Add(archer5);
        Console.WriteLine($"关卡中出现了{enemies.Count}个弓箭手敌人。");

        Console.WriteLine("玩家轻松带走小脆皮们");

        Console.WriteLine("玩家进入了一个新的关卡。");
        var enemies2 = new List<IUnit>();
        var warrior = new Warrior();
        enemies2.Add(warrior);
        var warrior2 = new Warrior();
        enemies2.Add(warrior2);
        var warrior3 = new Warrior();
        enemies2.Add(warrior3);
        var warrior4 = new Warrior();
        enemies2.Add(warrior4);
        var warrior5 = new Warrior();
        enemies2.Add(warrior5);

        Console.WriteLine($"关卡中出现了{enemies2.Count}个壮汉。");

        Console.WriteLine("玩家被按在地上摩擦");
        Console.WriteLine("垃圾游戏, 直接删除了。");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用工厂方法模式的代码:");

        Console.WriteLine("玩家游玩肉鸽游戏");

        var level1 = new Level1();
        level1.StartLevel();

        Console.WriteLine("玩家轻松带走小脆皮们");

        var level2 = new Level2();
        level2.StartLevel();

        Console.WriteLine("玩家被按在地上摩擦");
        Console.WriteLine("垃圾游戏, 直接删除了。");
    }
}