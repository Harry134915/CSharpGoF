namespace Adapter;

/// <summary>
/// 被适配者：手枪。
/// </summary>
public class Pistol
{
    /// <summary>
    /// 手枪的攻击方法。
    /// </summary>
    public void Fire()
    {
        Console.WriteLine("手枪开火");
    }
}