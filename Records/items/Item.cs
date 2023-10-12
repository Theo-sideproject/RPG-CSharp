using Records.items;

namespace Records;

public class Item
{
    protected string name;
    protected int health;
    protected int boostDmg;
    protected ETypeItems type;


    public Item(string name,int boostDmg,int health)
    {
        this.name = name;
        this.health = health;
        this.boostDmg = boostDmg;
    }

}