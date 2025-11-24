using UnityEngine;

public class player : MonoBehaviour
{
    int hp = 100;
    int dmg = 15;
    int special = 50;
    Vector2 direction = new Vector2((float)0.5, 0);

   // Update is called once per frame
   void Update()
    {
        transform.Translate(direction*Time.deltaTime);
    }
}
