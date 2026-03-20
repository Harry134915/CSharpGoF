namespace Adapter;

/// <summary>
/// 新的角色类，使用适配器接口进行攻击。
/// </summary>
public class CharacterNew
{
    /// <summary>
    /// 攻击方法，接收实现了 IWeaponAdapter 的武器适配器。
    /// </summary>
    /// <param name="weapon">实现 IWeaponAdapter 的武器适配器</param>
    public void Attack(IWeaponAdapter weapon)
    {
        weapon.Attack(); // 只需调用统一的 Attack 方法
    }
}