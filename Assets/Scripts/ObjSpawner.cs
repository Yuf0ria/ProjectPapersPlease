using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjSpawner : MonoBehaviour
{
    //not an array because I nooking the papers orrr
    //nope array, nope
    public GameObject Chair, Paper;
        // Book, Notebooks;

    //obj that do nothing and can serve as obstacles: chair
    //obj that have effects when picked up by the player: paper, books, notebooks
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 chairSpawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            Instantiate(Chair, chairSpawnPos, Quaternion.identity);
        }
            
        for (int p = 0; p < 5; p++)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            yield return new WaitForSeconds(2);
            Instantiate(Paper, randomSpawnPos, Quaternion.identity);

            yield return new WaitForSeconds(5);
            Destroy(Paper);//better to destroy this using compare tag so I won't get an error ;-;
            Debug.Log(" Paper Gone Byebye ");

        }
        // if (randomArray <= 5)
        // {
        //     Instantiate(objects[randomArray], randomSpawnPos, Quaternion.identity);
        // }
    }
}
