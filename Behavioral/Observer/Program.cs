namespace Observer;

/// <summary>
/// 观察者模式（Observer Pattern）
/// 是一种 行为型设计模式。
/// 
/// 核心思想:
/// 当一个对象状态改变时，自动通知所有依赖它的对象。
///
/// 也就是一对多通知
///
/// 关键点不是“事件”，而是"解耦"
///
/// 结构:
/// Subject（被观察者）
///     ↓
/// Observer（观察者）
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();

        //使用Event
        UsedEvent();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        Console.WriteLine("创建玩家");
        var uiSystem = new UiSystem();
        var soundSystem = new SoundSystem();

        var player = new Player("Hero", 100, uiSystem, soundSystem);

        var damage = 20;
        Console.WriteLine($"对玩家造成{damage}伤害");
        player.TakeDamage(damage);

        //因为是直接调用uiSystem和soundSystem的方法, 所以player需要直接依赖uiSystem和soundSystem,
        //导致代码耦合度高, 具体细节看Player的实现
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用观察者模式的代码:");

        Console.WriteLine("创建玩家");
        var uiSystem = new UiSystemNew();
        var soundSystem = new SoundSystemNew();

        var player = new PlayerNew("Hero", 100);
        player.AddObserver(uiSystem);
        player.AddObserver(soundSystem);

        var damage = 20;
        Console.WriteLine($"对玩家造成{damage}伤害");
        player.TakeDamage(damage);
    }

    private static void UsedEvent()
    {
        Console.WriteLine("\n使用event来实现观察者模式的代码:");

        Console.WriteLine("创建玩家");
        var uiSystem = new UiSystem();
        var soundSystem = new SoundSystem();

        var player = new PlayerUsedEvent("Hero", 100);
        player.OnHealthChanged += uiSystem.UpdateHealthBar;
        player.OnHealthChanged += soundSystem.PlayDamageSound;

        var damage = 20;
        Console.WriteLine($"对玩家造成{damage}伤害");
        player.TakeDamage(damage);

        //event 本身就是观察者模式的一个实现机制, 你使用它，就是在使用观察者模式
    }
}