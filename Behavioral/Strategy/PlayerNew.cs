using Strategy.AttackStrategy;

namespace Strategy;

public class PlayerNew
{
    private IAttackStrategy _attackStrategy = new DefaultAttackStrategy();

    public void SetAttackStrategy(IAttackStrategy attackStrategy)
    {
        _attackStrategy = attackStrategy;
    }

    public void Attack()
    {
        _attackStrategy.Attack();
    }
}