using SimpleFactory.Weapons;

namespace SimpleFactory;

public class Character
{
    private IWeapon _weapon;

    public Character() : this(new DefaultWeapon())
    {
    }

    public Character(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Attack()
    {
        _weapon.Use();
    }
}