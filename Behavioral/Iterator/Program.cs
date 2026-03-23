namespace Iterator;

/// <summary>
/// 迭代器模式（Iterator Pattern）
/// 是一种 结构型设计模式。
/// 
/// 定义:
/// 提供一种方法，顺序访问一个集合中的元素，而不暴露其内部结构。
///
/// 结构:
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

        var weaponInventory = new WeaponInventory();
        var pistol = new Pistol();
        var knife = new Knife();

        weaponInventory.Weapons.Add(pistol);
        weaponInventory.Weapons.Add(knife);

        foreach (var weapon in weaponInventory.Weapons)
        {
            weapon.Attack();
        }

        // ❌ 暴露内部结构（List）
        // ❌ 如果换成数组 / 链表 → 全部代码要改
        // ❌ 外部依赖内部实现
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用迭代器模式的代码:");

        var weaponInventory = new WeaponInventoryNew();
        var pistol = new Pistol();
        var knife = new Knife();

        weaponInventory.AddWeapon(pistol);
        weaponInventory.AddWeapon(knife);

        foreach (var weapon in weaponInventory)
        {
            weapon.Attack();
        }
    }
}