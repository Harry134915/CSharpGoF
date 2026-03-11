namespace Strategy.AttackStrategy;

public class MagicAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("玩家发射火球!");
    }
}