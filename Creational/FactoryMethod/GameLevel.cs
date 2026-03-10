namespace FactoryMethod;

public abstract class GameLevel
{
    public List<IUnit>? Enemies { get; set; }

    /// <summary>
    /// 创建敌人的工厂方法, 由子类实现, 这个工厂只负责创建敌人
    /// </summary>
    /// <returns></returns>
    public abstract List<IUnit> CreateEnemies();

    public void StartLevel()
    {
        Console.WriteLine("玩家进入了一个新的关卡。");
        Enemies = CreateEnemies();
    }
}