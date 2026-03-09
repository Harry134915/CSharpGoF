using SimpleFactory.Weapons;

namespace SimpleFactory;

/// <summary>
/// 简单工厂模式（Simple Factory Pattern）
/// 其实不是 GoF（《设计模式》）里正式的 23 种设计模式之一，
/// 但它是最常见、最容易理解的一种“工厂思想”。
/// 很多后续的模式（如工厂方法、抽象工厂）都是从它演化出来的。
/// 
/// 核心思想:
/// 把创建对象的逻辑集中到一个类里，而不是到处 new
/// </summary>
internal class Program
{
    /// <summary>
    /// 游戏里有三种武器： Sword（剑）, Bow（弓）, Staff（法杖）
    /// 你需要创建他们的实例来使用他们.
    /// 对比未使用设计模式的代码和使用简单工厂模式的代码
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        //未使用简单工厂模式
        UnusedDesignPattern();

        //使用简单工厂模式
        UsedDesignPattern();
    }

    /// <summary>
    /// 未使用设计模式的代码
    /// 客户端代码越来越复杂, 违反开闭原则, 创建逻辑到处都是
    /// </summary>
    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        Console.WriteLine("新玩家进入游戏世界");
        var player = new Character();
        Console.WriteLine("玩家控制角色进行攻击, 但是玩家没有武器, 只能进行徒手攻击");
        player.Attack();

        Console.WriteLine("玩家在路边捡到一把剑, 并换上了这把剑");
        var sword = new Sword();
        player.SetWeapon(sword);
        Console.WriteLine("玩家使用剑进行攻击");
        player.Attack();
        Console.WriteLine("玩家对这把剑很满意, 继续使用这把剑进行攻击");
        player.Attack();

        Console.WriteLine("这时候玩家又捡到了一把弓, 近战那有远程安全, 选择换上了这把弓");
        var bow = new Bow();
        player.SetWeapon(bow);
        Console.WriteLine("玩家使用弓进行攻击, 弓箭数量-1");
        player.Attack();
        Console.WriteLine("玩家继续使用弓进行攻击, 弓箭数量-1");
        player.Attack();
        Console.WriteLine("玩家继续使用弓进行攻击, 弓箭数量-1");
        player.Attack();

        Console.WriteLine("弓箭已经用完了, 只能进行徒手攻击了");
        var defaultWeapon = new DefaultWeapon();
        player.SetWeapon(defaultWeapon);
        player.Attack();

        Console.WriteLine("玩家又捡到了一把法杖, 一代版本一代神，代代版本是法神, 于是选择换上了这把法杖");
        var staff = new Staff();
        player.SetWeapon(staff);
        Console.WriteLine("玩家使用法杖进行攻击");
        player.Attack();

        Console.WriteLine("玩家智力不足, 使用法杖攻击还不如徒手攻击, 选择换回了徒手攻击");
        var defaultWeapon2 = new DefaultWeapon();
        player.SetWeapon(defaultWeapon2);
        player.Attack();
    }

    /// <summary>
    /// 使用简单工厂模式的代码
    /// </summary>
    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用简单工厂模式的代码:");

        Console.WriteLine("新玩家进入游戏世界");
        var player = new Character();
        Console.WriteLine("玩家控制角色进行攻击, 但是玩家没有武器, 只能进行徒手攻击");
        player.Attack();

        Console.WriteLine("玩家在路边捡到一把剑, 并换上了这把剑");
        var sword = WeaponFactory.CreateWeapon(WeaponType.Sword);
        player.SetWeapon(sword);
        Console.WriteLine("玩家使用剑进行攻击");
        player.Attack();
        Console.WriteLine("玩家对这把剑很满意, 继续使用这把剑进行攻击");
        player.Attack();

        Console.WriteLine("这时候玩家又捡到了一把弓, 近战那有远程安全, 选择换上了这把弓");
        var bow = WeaponFactory.CreateWeapon(WeaponType.Bow);
        player.SetWeapon(bow);
        Console.WriteLine("玩家使用弓进行攻击, 弓箭数量-1");
        player.Attack();
        Console.WriteLine("玩家继续使用弓进行攻击, 弓箭数量-1");
        player.Attack();
        Console.WriteLine("玩家继续使用弓进行攻击, 弓箭数量-1");
        player.Attack();

        Console.WriteLine("弓箭已经用完了, 只能进行徒手攻击了");
        var defaultWeapon = WeaponFactory.CreateWeapon(WeaponType.Default);
        player.SetWeapon(defaultWeapon);
        player.Attack();

        Console.WriteLine("玩家又捡到了一把法杖, 一代版本一代神，代代版本是法神, 于是选择换上了这把法杖");
        var staff = WeaponFactory.CreateWeapon(WeaponType.Staff);
        player.SetWeapon(staff);
        Console.WriteLine("玩家使用法杖进行攻击");
        player.Attack();

        Console.WriteLine("玩家智力不足, 使用法杖攻击还不如徒手攻击, 选择换回了徒手攻击");
        var defaultWeapon2 = WeaponFactory.CreateWeapon(WeaponType.Default);
        player.SetWeapon(defaultWeapon2);
        player.Attack();
    }
}