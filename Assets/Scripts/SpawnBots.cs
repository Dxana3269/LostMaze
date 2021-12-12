/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBots : MonoBehaviour
{
    public List<GameObject> targetPrefabs;

    public float currentTime;
    public float startingTime = 60f;

    private int score;
    private float spawnRate = 1.5f;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // While game is active spawn a random target
        IEnumerator SpawnBots()
        {
            while (isGameActive)
            {
                if (currentTime <= 0)
                {
                    GameOver();
                }

                yield return new WaitForSeconds(spawnRate);
                int index = Random.Range(0, targetPrefabs.Count);

                if (isGameActive)
                {
                    Instantiate(targetPrefabs[index], RandomSpawnPosition(), targetPrefabs[index].transform.rotation);
                }

            }
        }

        // Generate a random spawn position (based on a random index from 0 to 3)
        Vector3 RandomSpawnPosition()
        {
            Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
            return spawnPosition;

        }

    }
}
*/