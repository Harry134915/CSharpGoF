namespace State;

/// <summary>
/// 状态模式（State Pattern）
/// 是一种 行为型设计模式。
/// 
/// 定义:
/// 允许对象在内部状态改变时改变它的行为，看起来像改变了类。
///
/// 用“状态对象”替代一堆 if / switch
///
/// 状态模式，本质上就是“面向对象写法的状态机”
///
/// 结构:
/// Context（上下文）
///    ↓
/// State（状态接口）
///    ↓
/// ConcreteState（具体状态）
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");
        var player = new Player();
        player.Update();
        player.State = CharacterState.Walking;
        player.Update();
        player.State = CharacterState.Running;
        player.Update();
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用状态模式的代码:");
        var player = new PlayerNew();
        player.Update();
        player.ChangeState(CharacterState.Walking);
        player.Update();
        player.ChangeState(CharacterState.Running);
        player.Update();
    }
}