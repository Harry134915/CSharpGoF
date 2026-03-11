namespace Strategy.AttackStrategy;

public class SwordAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("玩家挥舞剑!");
    }
}