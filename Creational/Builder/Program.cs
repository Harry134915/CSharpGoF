namespace Builder;

internal class Program
{
    /// <summary>
    /// 建造者模式（Builder Pattern）
    /// 是一种 创建型设计模式。
    /// 
    /// 核心思想:
    /// 将复杂对象的构建过程与表示分离，使同样的构建过程可以创建不同的对象。
    ///
    /// 结构:
    /// Director（指挥者）
    /// ↓
    /// Builder（建造者）
    /// ↓
    /// ConcreteBuilder（具体建造者）
    /// ↓
    /// Product（产品）
    /// 
    /// 注意:
    /// 一步一步构建对象, 而不是一次性 new 出来
    /// </summary>
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

        Console.WriteLine("创建一个复杂对象: 哥布林");
        //当参数变多：20~30个属性, 代码会变得：难读,难维护,容易出错
        var character = new Character();
        character.Name = "哥布林";
        character.Health = 100;
        character.Defense = 10;
        character.Damage = 15;
        character.AttackSpeed = 1.5f;
        character.MoveSpeed = 12f;
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用建造者模式的代码:");

        var characterBuilder = new CharacterBuilder();
        characterBuilder.SetName("哥布林")
                        .SetHealth(100)
                        .SetDefense(10)
                        .SetDamage(15)
                        .SetAttackSpeed(1.5f)
                        .SetMoveSpeed(12f).Build();

        var character = characterBuilder.Build();
    }
}