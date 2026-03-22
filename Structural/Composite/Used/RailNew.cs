namespace Composite.Used;

public class RailNew : IItem
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
        Console.WriteLine("应用导轨属性");
        foreach (var item in _items)
        {
            item.ApplyStats();
        }
    }
}