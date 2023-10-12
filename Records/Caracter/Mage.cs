using Caracter;

class Mage : Character
{
    private int mana;
    // private int weaponComsuption;

    public Mage(string name, int health,Weapon weapon)
    {
        this.name = name;
        this.health = health;
        this.mana = 100;
        this.weapon = weapon;
        // this.weaponComsuption = (int)WeaponCompsumMana.BatonMagic;
    }

    // public void AttackMagic(Character opponent)
    // {
    // }

}