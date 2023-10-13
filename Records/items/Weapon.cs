using Records;
using Records.items;

namespace Caracter;

public class Weapon : Item
{
    public int WeaponDamage { get; protected set; }

    public Weapon(string name, int dmg) : base(name, dmg, 0, ETypeItems.Weapon)
    {

    }
}