namespace Strategy.AttackStrategy;

public class DefaultAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("玩家使用空手攻击!");
    }
}