using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class enemy: MonoBehaviour
{
    
    public virtual void attaque()
    {
        Debug.Log("l'ennemi attaque!");
    }
}
public class goblin : enemy
{
    public override void attaque()
    {
        int lp = 50;
        int atk = 1;
        Debug.Log("un goblin vous assènne un coup!");
    }
}
public class squelette : enemy
{
    public override void attaque()
    {
        int lp = 75;
        int atk = 2;
        Debug.Log("un squellette vous lance sa côte!");
    }
}
public class orc : enemy
{
    public override void attaque()
    {
        int lp = 100;
        int atk = 3;
        Debug.Log("un orc vous assome avec sa massue!");
    }
    
}
