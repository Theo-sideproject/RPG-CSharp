namespace Caracter;

public class Enemy
{
    protected string name;
    protected int health;
    protected Weapon weapon;

    public Enemy(string name, int health, Weapon weapon)
    {
        this.name = name;
        this.health = health;
        this.weapon = weapon;
    }

    public void Attack(Character opponent)
    {
        opponent.TakeDamage(5);
    }
}