using Caracter;
using Records;

internal class Program
{
    private static void Main()
    {
        Weapon hache = new Weapon("Hache",20);
        Weapon epee = new Weapon("Epée rouilée",10);

        Mage mage1 = new Mage("gandalf", 100,hache);
        Mage mage2 = new Mage("Pute", 100,epee);

        // mage1.AttackMagic(mage2);

        mage2.UseItem(epee);

        mage2.Attack(mage1);

        mage1.Show();
    }
}