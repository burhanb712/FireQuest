using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject fire;

    void Start()
    {
        int iterationCount = 100;
        for (int i = 0; i < iterationCount; i++)
        {
            int spawnPointx = Random.Range(1600, 2000);
            int spawnPointy = 0;
            int spawnPointz = Random.Range(2200, 2600);

            Vector3 spawnPosition = new Vector3(spawnPointx, spawnPointy, spawnPointz);

            Instantiate(fire, spawnPosition, Quaternion.identity);
        }
    }

}
