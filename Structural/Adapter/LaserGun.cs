namespace Adapter;

/// <summary>
/// 被适配者：激光枪。
/// </summary>
public class LaserGun
{
    /// <summary>
    /// 激光枪的攻击方法。
    /// </summary>
    public void ShootLaser()
    {
        Console.WriteLine("发射激光");
    }
}