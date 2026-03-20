namespace Adapter;

/// <summary>
/// 激光枪的适配器，实现统一的武器接口。
/// </summary>
public class LaserGunAdapter : IWeaponAdapter
{
    /// <summary>
    /// 被适配的激光枪对象。
    /// </summary>
    private LaserGun _laserGun;

    /// <summary>
    /// 构造函数，注入被适配的 LaserGun 对象。
    /// </summary>
    /// <param name="laserGun">要适配的激光枪对象</param>
    public LaserGunAdapter(LaserGun laserGun)
    {
        _laserGun = laserGun;
    }

    /// <summary>
    /// 实现统一的攻击方法，内部调用 LaserGun 的 ShootLaser 方法。
    /// </summary>
    public void Attack()
    {
        _laserGun.ShootLaser();
    }
}