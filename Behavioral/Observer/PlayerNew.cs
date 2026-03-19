namespace Observer;

public class PlayerNew
{
    public string Name { get; set; }
    public int Health { get; set; }

    /// <summary>
    /// 观察者列表，存储所有订阅者。
    /// </summary>
    private List<IObserver<int>> _observers = new();

    public PlayerNew(string name, int health)
    {
        Name = name;
        Health = health;
    }


    /// <summary>
    /// 添加观察者。
    /// </summary>
    public void AddObserver(IObserver<int> obs)
    {
        _observers.Add(obs);
    }

    /// <summary>
    /// 玩家受到伤害，生命值减少，并通知所有观察者。
    /// </summary>
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} 受到 {damage} 伤害, 生命值现在为 {Health}");

        NotifyHealthChanged(Health);
    }

    /// <summary>
    /// 通知所有观察者生命值变化。
    /// </summary>
    public void NotifyHealthChanged(int health)
    {
        foreach (var obs in _observers)
        {
            obs.OnNext(health);
        }
    }
}