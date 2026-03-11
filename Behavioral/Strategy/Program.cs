using Strategy.AttackStrategy;

namespace Strategy;

/// <summary>
/// 策略模式（Strategy Pattern）
/// 是一种 行为型设计模式。
/// 
/// 核心思想:
/// 把一组算法封装起来，并且可以在运行时自由替换。
/// 
/// 注意:
/// 同一个行为
/// 多种实现方式
/// 运行时选择一种
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

        Console.WriteLine("玩家进入游戏世界");
        var player = new Player();

        Console.WriteLine("玩家装备剑");
        player.AttackType = AttackType.Sword;
        player.Attack();

        Console.WriteLine("玩家装备弓");
        player.AttackType = AttackType.Bow;
        player.Attack();

        Console.WriteLine("玩家装备法杖");
        player.AttackType = AttackType.Magic;
        player.Attack();
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用策略模式的代码:");

        Console.WriteLine("玩家进入游戏世界");
        var swordAttackStrategy = new SwordAttackStrategy();
        var bowAttackStrategy = new BowAttackStrategy();
        var magicAttackStrategy = new MagicAttackStrategy();

        var player = new PlayerNew();

        Console.WriteLine("玩家装备剑");
        player.SetAttackStrategy(swordAttackStrategy);
        player.Attack();

        Console.WriteLine("玩家装备弓");
        player.SetAttackStrategy(bowAttackStrategy);
        player.Attack();

        Console.WriteLine("玩家装备法杖");
        player.SetAttackStrategy(magicAttackStrategy);
        player.Attack();
    }
}