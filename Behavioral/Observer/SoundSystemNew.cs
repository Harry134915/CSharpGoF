namespace Observer;

public class SoundSystemNew : IObserver<int>
{
    /// <summary>
    /// 播放受伤音效。
    /// </summary>
    public void PlayDamageSound(int damage)
    {
        Console.WriteLine($"播放声音: 受到伤害的声音");
    }

    /// <summary>
    /// 通知观察者：数据流已完成。例如角色死亡后，声音系统可停止播放。
    /// </summary>
    public void OnCompleted()
    {
        Console.WriteLine("角色死亡, 清除该组件运行");
    }

    /// <summary>
    /// 通知观察者：数据流发生异常。例如游戏逻辑出错时，声音系统可播放错误提示音。
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
        PlayDamageSound(value);
    }
}