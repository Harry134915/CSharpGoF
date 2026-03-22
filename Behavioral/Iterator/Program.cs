namespace Iterator;

/// <summary>
/// 迭代器模式（Iterator Pattern）
/// 是一种 结构型设计模式。
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
        Console.WriteLine("\n使用迭代器模式的代码:");
    }
}