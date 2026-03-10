using FactoryMethod.Unit;

namespace FactoryMethod.Level;

public class Level2 : GameLevel
{
    public override List<IUnit> CreateEnemies()
    {
        var enemies = new List<IUnit>();

        //按理来说应该使用工厂模式来创建, 但是怕引入使用工厂模式对工厂模式带来的干扰, 就直接new了
        enemies.Add(new Warrior());
        enemies.Add(new Warrior());
        enemies.Add(new Warrior());
        enemies.Add(new Warrior());
        enemies.Add(new Warrior());
        Console.WriteLine($"关卡中出现了{enemies.Count}个壮汉。");
        return enemies;
    }
}