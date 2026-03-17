namespace Builder;

public class CharacterBuilder
{
    private Character _character;

    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetHealth(int health)
    {
        _character.Health = health;
        return this;
    }

    public CharacterBuilder SetDefense(int defense)
    {
        _character.Defense = defense;
        return this;
    }

    public CharacterBuilder SetDamage(int damage)
    {
        _character.Damage = damage;
        return this;
    }

    public CharacterBuilder SetAttackSpeed(float attackSpeed)
    {
        _character.AttackSpeed = attackSpeed;
        return this;
    }

    public CharacterBuilder SetMoveSpeed(float moveSpeed)
    {
        _character.MoveSpeed = moveSpeed;
        return this;
    }


    public Character Build()
    {
        return _character;
    }
}