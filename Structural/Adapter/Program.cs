namespace Adapter;

/// <summary>
/// 适配器模式（Adapter Pattern）
/// 是一种 结构型设计模式。
/// 
/// 定义:
/// 把一个类的接口转换成客户端期望的另一个接口，让原本不兼容的类可以一起工作。
///
/// 特点:
/// “不修改旧代码的前提下，接入新系统”
///
/// 结构:
/// Client → ITarget（IWeapon）
///             ↑
///          Adapter
///             ↓
///          Adaptee（LaserGun）
///
/// 对比: Adapter vs Proxy
/// 适配器模式 和 代理模式 外形几乎一样，都是“包一层”。
/// 代理模式: 代理类和被代理类会实现同样的接口, 不改变“接口”，改变“行为”
/// 适配器模式: 适配器类和被适配类不会实现同样的接口, 改变“接口”
/// 
/// |  模式  |    接口    |  目的   |
/// | ----- | --------- | ------ |
/// | 适配器 | ❌ 不一样 | 转换接口 |
/// | 代理  | ✅ 一样   | 控制访问 |
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

        var laserGun = new LaserGun();
        var pistol = new Pistol();
        var knife = new Knife();
        var character = new Character();
        character.Attack(laserGun);
        character.Attack(pistol);
        character.Attack(knife);
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用适配器模式的代码:");

        var laserGunAdapter = new LaserGunAdapter(new LaserGun());
        var pistolAdapter = new PistolAdapter(new Pistol());
        var knifeAdapter = new KnifeAdapter(new Knife());
        var character = new CharacterNew();
        character.Attack(laserGunAdapter);
        character.Attack(pistolAdapter);
        character.Attack(knifeAdapter);
    }
}