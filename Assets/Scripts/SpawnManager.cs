using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 15f;
    public float spawnPosZ = 20f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SpawnRandomAnimal();
    }

    private void SpawnRandomAnimal()
    {
        // get random x value between -20 , 20 for the spawn position
        Vector3 _spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // get random animal index
        int _animalIndex = Random.Range(0, animalPrefabs.Length);

        // spawn random animal on random position
        Instantiate(animalPrefabs[_animalIndex], _spawnPos, animalPrefabs[_animalIndex].transform.rotation);
    }
}
