using UnityEngine;

public class orcenemy : MonoBehaviour
{
    Vector2 direction = new Vector2((float)-0.5, 0);
    public class orc : enemy
    {
        public override void attaque()
        {
            int lp = 100;
            int atk = 3;
            Debug.Log("un orc vous assome avec sa massue!");
        }

    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);

    }
}
