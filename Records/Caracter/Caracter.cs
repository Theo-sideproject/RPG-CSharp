using Records;
using Records.items;

namespace Caracter;

public class Character
{
    protected string name;
    protected int health;
    protected Weapon weapon;
    protected Item Helmet;
    protected Item ChestPlate;
    protected Item Boot;

    public void Attack(Character opponent)
    {
        opponent.TakeDamage(this.weapon.WeaponDamage);
    }

    public void TakeDamage(int damage)
    {
        this.health -= dommage;
    }

    public void UseItem(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void Show()
    {
        Console.WriteLine("name : " + name);
        Console.WriteLine("baseDamage : " + this.weapon.WeaponDamage);
        Console.WriteLine("health : " + health);
        this.weapon.Show();
    }
}
