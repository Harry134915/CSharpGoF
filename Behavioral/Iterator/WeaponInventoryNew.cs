namespace Iterator;

public class WeaponInventoryNew
{
    private List<IWeapon> _weapons = new();

    public void AddWeapon(IWeapon weapon)
    {
        _weapons.Add(weapon);
    }

    public IEnumerator<IWeapon> GetEnumerator()
    {
        return _weapons.GetEnumerator();
    }
}