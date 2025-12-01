using UnityEngine;

public class squelletteenemy : MonoBehaviour
{
    public class squelette : enemy
    {
        public override void attaque()
        {
            int lp = 75;
            int atk = 2;
            Debug.Log("un squellette vous lance sa côte!");
        }
    }
}