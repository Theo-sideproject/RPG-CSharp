namespace Caracter;

public class Weapon
{
    public int WeaponDamage { get; protected set; }
    public string name { get; protected set; }

    public Weapon(string name,int dmg)
    {
        this.name = name;
        this.WeaponDamage = dmg;
    }

    public void Show()
    {
        Console.WriteLine("Weapon name :"+ name);
        Console.WriteLine("Weapon Dmg :"+ WeaponDamage);
    }
}