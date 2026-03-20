namespace Adapter;

/// <summary>
/// 角色类，负责攻击操作。
/// </summary>
public class Character
{
    /// <summary>
    /// 攻击方法，接收不同类型的武器对象。
    /// </summary>
    /// <param name="weapon">武器对象</param>
    public void Attack(object weapon)
    {
        // ❌ 每增加一个新武器，就要改 Character
        // ❌ if / else 无限增长
        // ❌ 系统越来越难维护
        // ❌ 强耦合（Character 知道所有类型）
        // 下面是对不同武器类型的判断和调用各自的方法
        if (weapon is LaserGun laserGun)
        {
            laserGun.ShootLaser();
        }
        else if (weapon is Pistol pistol)
        {
            pistol.Fire();
        }
        else if (weapon is Knife knife)
        {
            knife.Stab();
        }
        else
        {
            Console.WriteLine("未知武器");
        }
    }
}