using Caracter;

class Mage : Character
{
    private int mana;

    public Mage(string name, int health, Weapon weapon)
    {
        this.name = name;
        this.health = health;
        this.mana = 100;
        this.weapon = weapon;
        // this.weaponComsuption = (int)WeaponCompsumMana.BatonMagic;
    }

}