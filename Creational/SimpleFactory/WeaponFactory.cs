// WeaponFactory：简单工厂模式，负责创建各种武器实例，屏蔽具体实现细节

using SimpleFactory.Weapons;

namespace SimpleFactory;

public static class WeaponFactory
{
    /// <summary>
    /// 根据武器类型创建对应的武器实例
    /// </summary>
    /// <param name="weaponType">武器类型枚举</param>
    /// <returns>IWeapon接口实例</returns>
    /// <exception cref="ArgumentException">未知武器类型时抛出</exception>
    public static IWeapon CreateWeapon(WeaponType weaponType)
    {
        switch (weaponType)
        {
            case WeaponType.Default:
                // 创建默认武器（无武器状态）
                return new DefaultWeapon();
            case WeaponType.Sword:
                // 创建剑武器
                return new Sword();
            case WeaponType.Bow:
                // 创建弓武器
                return new Bow();
            case WeaponType.Staff:
                // 创建法杖武器
                return new Staff();
            default:
                // 未知类型，抛出异常
                throw new ArgumentException($"未知武器类型: {weaponType}", nameof(weaponType));
        }
    }
}