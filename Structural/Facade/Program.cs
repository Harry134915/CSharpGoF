namespace Facade;

internal class Program
{
    /// <summary>
    /// 外观模式（Facade Pattern）
    /// 是一种 结构型设计模式。
    /// 
    /// 核心思想:
    /// 为复杂的子系统提供一个统一的简单接口。
    ///
    /// 结构:
    /// Client
    /// ↓
    /// Facade
    /// ↓
    /// SubsystemA
    /// SubsystemB
    /// SubsystemC
    /// 
    /// 注意:
    /// 隐藏复杂性, 提供简单入口
    ///
    /// 外观模式 vs 代理模式 vs 装饰模式
    /// 外观模式
    /// 目的: 简化复杂系统
    /// 结构: Client → Facade → 多个系统
    ///
    /// 代理模式
    /// 目的: 控制访问
    /// 结构: Client → Proxy → RealObject
    ///
    /// 装饰模式
    /// 目的: 增强对象功能
    /// 结构: Client → Decorator → Object
    /// </summary>
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

        //玩家开火需要进行以下步骤: 1.动画系统播放shoot动画. 2.弹匣的子弹数量-1. 3.应用枪械后坐力. 4.播放开枪的声音. 5.粒子系统播放枪口特效
        Console.WriteLine("玩家进行开火!");
        var animationSystem = new AnimationSystem();
        animationSystem.Play("射击动画");

        var ammoSystem = new AmmoSystem();
        ammoSystem.ConsumeBullet();

        var recoilSystem = new RecoilSystem();
        recoilSystem.ApplyRecoil();

        var soundSystem = new SoundSystem();
        soundSystem.PlaySound("枪声");

        var particleSystem = new ParticleSystem();
        particleSystem.SpawnParticle("枪口闪光");

        //完成一次射击的逻辑需要依赖多个系统, 代码耦合度高, 不利于维护和扩展
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用外观模式的代码:");

        //玩家开火需要进行以下步骤: 1.动画系统播放shoot动画. 2.弹匣的子弹数量-1. 3.应用枪械后坐力. 4.播放开枪的声音. 5.粒子系统播放枪口特效
        Console.WriteLine("玩家进行开火!");
        var gunFacade = new GunFacade();
        gunFacade.Shoot();

        //完成一次射击的逻辑由Facade类封装, 客户端调用只需要调用Shoot方法, 代码耦合度低, 易于维护和扩展
    }
}