using UnityEngine;
using System.Collections;

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
        for (int i = 0; i <= 5; i++)
        {
            Vector3 chairSpawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            Instantiate(Chair, chairSpawnPos, Quaternion.identity);
        }

        while (true)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            Instantiate(Paper, randomSpawnPos, Quaternion.identity);
            var paperGone = GameObject.FindGameObjectWithTag("Paper");
            Destroy(paperGone, 3f);
            yield return new WaitForSeconds(2);
        }
    }
}
