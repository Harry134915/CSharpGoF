using FactoryMethod.Unit;

namespace FactoryMethod.Level;

public class LevelEnemiesCreator1 : LevelEnemiesCreator
{
    public override List<IUnit> CreateEnemies()
    {
        var enemies = new List<IUnit>();

        //按理来说应该使用工厂模式来创建, 但是怕引入使用工厂模式对工厂模式带来的干扰, 就直接new了
        enemies.Add(new Archer());
        enemies.Add(new Archer());
        enemies.Add(new Archer());
        enemies.Add(new Archer());
        enemies.Add(new Archer());
        Console.WriteLine($"关卡中出现了{enemies.Count}个弓箭手敌人。");

        return enemies;
    }
}