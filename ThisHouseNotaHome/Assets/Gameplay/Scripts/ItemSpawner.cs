using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {
    [SerializeField]
    private Collectible[] collectibles;
    private SpawnLocation[] spawnLocations;
    // Start is called before the first frame update
    void Start() {
        spawnLocations = FindObjectsOfType<SpawnLocation>();
        List<SpawnLocation> spawnLocAL = new List<SpawnLocation>(spawnLocations);
        foreach (Collectible col in collectibles) {
            int spawnIndex = Random.Range(0, spawnLocAL.Count);
            Instantiate(col.gameObject, spawnLocAL[spawnIndex].transform);
            spawnLocAL.RemoveAt(spawnIndex);
        }
    }
}
