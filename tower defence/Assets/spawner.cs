using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float waitCreateMonster = 2f;
    public GameObject[] myEnemiesToSpawn = new GameObject[2];

    void Start()
    {
        StartCoroutine(spawnDeleg());
    }
    IEnumerator spawnDeleg()
    {
        for (int i = 0; i < 3; i++) ;
        {
            yield return new WaitForSeconds(waitCreateMonster);
            float nRan = Random.Range(0f,1f);
        }
    }
}
