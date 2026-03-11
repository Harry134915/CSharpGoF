namespace Strategy.AttackStrategy;

public class BowAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("玩家射箭!");
    }
}