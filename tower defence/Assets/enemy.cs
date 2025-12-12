using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class enemy: MonoBehaviour
{
    
    
    public virtual void attaque()
    {
        Debug.Log("l'ennemi attaque!");
    }
    public void Movement()
    {
        Vector2 direction = new Vector2((float)-0.5, 0);
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
