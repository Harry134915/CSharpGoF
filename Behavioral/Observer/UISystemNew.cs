namespace Observer;

public class UiSystemNew : IObserver<int>
{
    /// <summary>
    /// 更新UI中的生命值显示。
    /// </summary>
    public void UpdateHealthBar(int health)
    {
        Console.WriteLine($"更新UI: 生命值现在为 {health}");
    }

    /// <summary>
    /// 通知观察者：数据流已完成。例如玩家死亡后，UI系统可以做收尾工作。
    /// </summary>
    public void OnCompleted()
    {
        Console.WriteLine("玩家已死亡，UI系统完成更新");
    }

    /// <summary>
    /// 通知观察者：数据流发生异常。例如游戏逻辑出错时，UI系统可显示错误提示。
    /// </summary>
    public void OnError(Exception error)
    {
        Console.WriteLine(error.Message);
    }

    /// <summary>
    /// 通知观察者：有新数据到达。此处为生命值变化。
    /// </summary>
    public void OnNext(int value)
    {
        UpdateHealthBar(value);
    }
}