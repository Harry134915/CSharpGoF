namespace Builder;

/// <summary>
/// 角色类，表示建造者模式中的角色
/// </summary>
public class Character
{
    /// <summary>
    /// 角色名称
    /// </summary>
    public string? Name;

    /// <summary>
    /// 生命值
    /// </summary>
    public int Health;

    /// <summary>
    /// 防御力
    /// </summary>
    public int Defense;

    /// <summary>
    /// 攻击力
    /// </summary>
    public int Damage;

    /// <summary>
    /// 攻击速度
    /// </summary>
    public float AttackSpeed;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed;

    public void Attack()
    {
        Console.WriteLine($"{Name} 进行攻击，造成 {Damage} 点伤害!");
    }
}