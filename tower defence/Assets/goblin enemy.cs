using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class goblinEnemy : MonoBehaviour
{
    public class goblin : enemy
    {
        public override void attaque()
        {
            int lp = 50;
            int atk = 1;
            Debug.Log("un goblin vous assènne un coup!");
        }
    }
}
