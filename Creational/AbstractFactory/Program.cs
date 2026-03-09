using AbstractFactory.Characters;
using AbstractFactory.Factories;
using AbstractFactory.Talents;

namespace AbstractFactory;

/// <summary>
/// 抽象工厂模式（Abstract Factory Pattern）
/// 是一种 创建型设计模式。
/// 
/// 核心思想:
/// 提供一个接口，用于创建“一系列相关或相互依赖的对象”，而无需指定它们的具体类。
/// 
/// 注意:
/// 抽象工厂的本意是“创建一组对象”，而不是“组装对象”
/// 抽象工厂在现实项目里其实用得不算多。
/// </summary>
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

        Console.WriteLine("玩家创建了一个人类角色，选择了一个天赋。");
        var human = new HumanCharacter();
        human.Talent = new HumanTalent();

        Console.WriteLine("玩家遇到强敌, 使用了人类角色的天赋。");
        human.UseTalent();

        Console.WriteLine("玩家不敌强敌, 觉得种族天赋不是很强, 选择了一个兽人角色，选择了一个天赋。");
        var orc = new OrcCharacter();
        orc.Talent = new OrcTalent();

        Console.WriteLine("玩家遇到强敌, 使用了兽人角色的天赋。");
        orc.UseTalent();

        Console.WriteLine("玩家战胜强敌, 但是因角色太丑了, 被Npc嫌弃, 于是选择了一个精灵角色，选择了一个天赋。");
        var elf = new ElfCharacter();
        elf.Talent = new ElfTalent();

        Console.WriteLine("玩家遇到哥布林群, 使用了精灵角色的天赋。");
        elf.UseTalent();

        Console.WriteLine("精灵魅力值高升高, 哥布林触发激昂效果, 于是不敌。");

        Console.WriteLine("玩家决定删除游戏。");
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用抽象工厂模式的代码:");

        var humanFactory = new HumanFactory();
        var orcFactory = new OrcFactory();
        var elfFactory = new ElfFactory();

        Console.WriteLine("玩家创建了一个人类角色，选择了一个天赋。");
        var human = CreateCharacter(humanFactory);

        Console.WriteLine("玩家遇到强敌, 使用了人类角色的天赋。");
        human.UseTalent();

        Console.WriteLine("玩家不敌强敌, 觉得种族天赋不是很强, 选择了一个兽人角色，选择了一个天赋。");
        var orc = CreateCharacter(orcFactory);

        Console.WriteLine("玩家遇到强敌, 使用了兽人角色的天赋。");
        orc.UseTalent();

        Console.WriteLine("玩家战胜强敌, 但是因角色太丑了, 被Npc嫌弃, 于是选择了一个精灵角色，选择了一个天赋。");
        var elf = CreateCharacter(elfFactory);

        Console.WriteLine("玩家遇到哥布林群, 使用了精灵角色的天赋。");
        elf.UseTalent();

        Console.WriteLine("精灵魅力值高升高, 哥布林触发激昂效果, 于是不敌。");

        Console.WriteLine("玩家决定删除游戏。");
    }

    private static ICharacter CreateCharacter(ICharacterFactory factory)
    {
        var character = factory.CreateCharacter();
        character.Talent = factory.CreateTalent();
        return character;
    }
}