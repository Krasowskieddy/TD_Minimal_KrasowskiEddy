using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class goblinEnemy : MonoBehaviour
{
    Vector2 direction = new Vector2((float)-0.5, 0);
    public class goblin : enemy
    {
        public override void attaque()
        {
            int lp = 50;
            int atk = 1;
            Debug.Log("un goblin vous assènne un coup!");
        }
    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
