namespace Prototype;

/// <summary>
/// 原型模式 (Prototype Pattern)
/// 一种 创建型设计模式 
///
/// 核心思想:
/// 通过复制（Clone）已有对象来创建新对象，而不是用 new。
///
/// 注意:
/// 不是创建对象, 而是复制对象
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

        Console.WriteLine("游戏世界中的怪物有哥布林, 猫妖, 牛头人");
        Console.WriteLine("玩家面前出现3只哥布林");
        var goblin1 = new Character();
        goblin1.Name = "Goblin";
        goblin1.Damage = 100;
        goblin1.Defense = 20;

        var goblin2 = new Character();
        goblin2.Name = "Goblin2";
        goblin2.Damage = 100;
        goblin2.Defense = 20;

        var goblin3 = new Character();
        goblin3.Name = "Goblin3";
        goblin3.Damage = 100;
        goblin3.Defense = 20;

        Console.WriteLine("玩家面前又出现2只猫妖");
        var cat1 = new Character();
        cat1.Name = "Cat";
        cat1.Damage = 50;
        cat1.Defense = 0;

        var cat2 = new Character();
        cat2.Name = "Cat2";
        cat2.Damage = 50;
        cat2.Defense = 0;

        Console.WriteLine("玩家面前接着出现1只牛头人");
        var minotaur = new Character();
        minotaur.Name = "Minotaur";
        minotaur.Damage = 200;
        minotaur.Defense = 50;

        goblin1.Attack();
        goblin2.Attack();
        goblin3.Attack();

        cat1.Attack();
        cat2.Attack();

        minotaur.Attack();

        Console.WriteLine("玩家被一群怪群殴至死, 毫无还手之力");

        Console.WriteLine("垃圾游戏, 退款");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用原型模式的代码:");

        Console.WriteLine("游戏世界中的怪物有哥布林, 猫妖, 牛头人");
        var goblinPrototype = new Character();
        goblinPrototype.Name = "Goblin";
        goblinPrototype.Damage = 100;
        goblinPrototype.Defense = 20;

        var catPrototype = new Character();
        catPrototype.Name = "Cat";
        catPrototype.Damage = 50;
        catPrototype.Defense = 0;

        var minotaurPrototype = new Character();
        minotaurPrototype.Name = "Minotaur";
        minotaurPrototype.Damage = 200;
        minotaurPrototype.Defense = 50;

        Console.WriteLine("玩家面前出现3只哥布林");
        var goblin1 = goblinPrototype.Clone();
        var goblin2 = goblinPrototype.Clone();
        var goblin3 = goblinPrototype.Clone();

        Console.WriteLine("玩家面前又出现2只猫妖");
        var cat1 = catPrototype.Clone();
        var cat2 = catPrototype.Clone();

        Console.WriteLine("玩家面前接着出现1只牛头人");
        var minotaur = minotaurPrototype.Clone();

        goblin1.Attack();
        goblin2.Attack();
        goblin3.Attack();

        cat1.Attack();
        cat2.Attack();

        minotaur.Attack();

        Console.WriteLine("玩家被一群怪群殴至死, 毫无还手之力");
        Console.WriteLine("垃圾游戏, 退款");
    }
}