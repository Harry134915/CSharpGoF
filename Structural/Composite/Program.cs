using Composite.Unused;
using Composite.Used;

namespace Composite;

/// <summary>
/// 组合模式（Composite Pattern）
/// 是一种 结构型设计模式。
/// 
/// 定义:
/// 把对象组合成树结构，让你可以“统一对待单个对象和组合对象”。
///
/// “一个东西 和 一堆东西，用同一套接口操作”
///
/// 树 / 层级 / 嵌套
/// 
/// 结构:
/// Component（统一接口）
///     ↑
/// Leaf（叶子节点）
/// Composite（组合节点）
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        var barrel = new Barrel();
        var scope = new Scope();
        var grip = new Grip();
        var rail = new Rail();
        var flash = new Flash();
        rail.AddAttachment(flash);
        var gun = new Gun();
        gun.Barrel = barrel;
        gun.Scope = scope;
        gun.Grip = grip;
        gun.Rail = rail;

        gun.ApplyStats();
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用组合模式的代码:");

        var barrel = new BarrelNew();
        var scope = new ScopeNew();
        var grip = new GripNew();
        var rail = new RailNew();

        var flash = new FlashNew();
        rail.AddItem(flash);

        var gun = new GunNew();
        gun.AddItem(barrel);
        gun.AddItem(scope);
        gun.AddItem(grip);
        gun.AddItem(rail);

        gun.ApplyStats();
    }
}