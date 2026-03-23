namespace Singleton;

/// <summary>
/// 单例模式（Singleton Pattern）
/// 是一种 创建型设计模式。
/// 
/// 定义:
///
///
/// 结构:
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
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用单例模式的代码:");
    }
}