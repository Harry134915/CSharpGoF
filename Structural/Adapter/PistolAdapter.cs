namespace Adapter;

/// <summary>
/// 手枪的适配器，实现统一的武器接口。
/// </summary>
public class PistolAdapter : IWeaponAdapter
{
    /// <summary>
    /// 被适配的手枪对象。
    /// </summary>
    private Pistol _pistol;

    /// <summary>
    /// 构造函数，注入被适配的 Pistol 对象。
    /// </summary>
    /// <param name="pistol">要适配的手枪对象</param>
    public PistolAdapter(Pistol pistol)
    {
        _pistol = pistol;
    }

    /// <summary>
    /// 实现统一的攻击方法，内部调用 Pistol 的 Fire 方法。
    /// </summary>
    public void Attack()
    {
        _pistol.Fire();
    }
}