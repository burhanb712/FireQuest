using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject fire;

    void Start()
    {
        int iterationCount = 200;
        for (int i = 0; i < iterationCount; i++)
        {
            int spawnPointx = Random.Range(30, 120);
            int spawnPointy = Random.Range(2, 3);
            int spawnPointz = Random.Range(-50, 60);

            Vector3 spawnPosition = new Vector3(spawnPointx, spawnPointy, spawnPointz);

            Instantiate(fire, spawnPosition, Quaternion.identity);
        }
    }

}
