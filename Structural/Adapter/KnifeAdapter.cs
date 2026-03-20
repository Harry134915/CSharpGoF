namespace Adapter;

/// <summary>
/// 刀的适配器，实现统一的武器接口。
/// </summary>
public class KnifeAdapter : IWeaponAdapter
{
    /// <summary>
    /// 被适配的刀对象。
    /// </summary>
    private Knife _knife;

    /// <summary>
    /// 构造函数，注入被适配的 Knife 对象。
    /// </summary>
    /// <param name="knife">要适配的刀对象</param>
    public KnifeAdapter(Knife knife)
    {
        _knife = knife;
    }

    /// <summary>
    /// 实现统一的攻击方法，内部调用 Knife 的 Stab 方法。
    /// </summary>
    public void Attack()
    {
        _knife.Stab();
    }
}