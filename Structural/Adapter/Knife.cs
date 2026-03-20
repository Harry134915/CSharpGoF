namespace Adapter;

/// <summary>
/// 被适配者：刀。
/// </summary>
public class Knife
{
    /// <summary>
    /// 刀的攻击方法。
    /// </summary>
    public void Stab()
    {
        Console.WriteLine("用刀刺");
    }
}