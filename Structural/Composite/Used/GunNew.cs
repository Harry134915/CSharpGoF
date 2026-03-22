namespace Composite.Used;

public class GunNew : IItem
{
    private List<IItem> _items = new();

    public void AddItem(IItem item)
    {
        _items.Add(item);
    }

    /// <summary>
    /// 应用属性
    /// </summary>
    public void ApplyStats()
    {
        foreach (var item in _items)
        {
            item.ApplyStats();
        }
    }
}