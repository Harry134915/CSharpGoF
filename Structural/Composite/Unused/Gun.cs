namespace Composite.Unused;

public class Gun
{
    public Barrel Barrel { get; set; }
    public Scope Scope { get; set; }
    public Grip Grip { get; set; }

    public Rail Rail { get; set; }

    /// <summary>
    /// 应用属性
    /// </summary>
    public void ApplyStats()
    {
        if (Barrel != null)
        {
            Barrel.ApplyStats();
        }

        if (Scope != null)
        {
            Scope.ApplyStats();
        }

        if (Grip != null)
        {
            Grip.ApplyStats();
        }

        if (Rail != null)
        {
            Rail.ApplyStats();
        }

        // ❌ 结构写死（Scope 才能有子节点）
        // ❌ 每增加一层都要改代码
        // ❌ 不支持任意嵌套
        // ❌ Gun 变成“上帝类”
        // ❌ 极难扩展（比如 rail + attachments）
    }
}