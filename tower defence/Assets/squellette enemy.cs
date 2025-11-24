using UnityEngine;

public class squelletteenemy : MonoBehaviour
{
    Vector2 direction = new Vector2 ((float)-0.5, 0);
    public class squelette : enemy
    {
        public override void attaque()
        {
            int lp = 75;
            int atk = 2;
            Debug.Log("un squellette vous lance sa côte!");
        }
    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);

    }
}