using Records.items;

namespace Records;

public class Item
{
    protected string name;
    protected int health;
    protected int boostDmg;
    protected ETypeItems type;


    public Item(string name,int boostDmg,int health,ETypeItems typeItems)
    {
        this.name = name;
        this.health = health;
        this.boostDmg = boostDmg;
        this.type = typeItems;
    }

    public void Show()
    {
        Console.WriteLine("Item name :" + name);
        Console.WriteLine("Item Dmg :" + boostDmg);
    }

    public override string ToString()
    {
        return $"Nom: {name}, type: {type}, boost : {health}h,{boostDmg}d";
    }

}