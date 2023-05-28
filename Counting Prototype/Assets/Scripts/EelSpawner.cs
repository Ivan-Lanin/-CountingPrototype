using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EelSpawner : MonoBehaviour {
    private float minZSpawnPoint = 5f;
    private float maxZSpawnPoint = 14f;
    private float minYSpawnPoint = 3f;
    private float maxYSpawnPoint = 7f;
    private GameObject eel;

    [SerializeField] private List<GameObject> eels = new List<GameObject>();

    public void SpawnEel() {
        eel = eels[Random.Range(0,2)];
        Instantiate(eel, new Vector3(0, Random.Range(minYSpawnPoint, maxYSpawnPoint), Random.Range(minZSpawnPoint, maxZSpawnPoint)), eel.transform.rotation);
    } 
}
