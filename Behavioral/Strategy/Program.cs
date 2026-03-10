namespace Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        //未使用简单工厂模式
        UnusedDesignPattern();

        //使用简单工厂模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用策略模式的代码:");
    }
}