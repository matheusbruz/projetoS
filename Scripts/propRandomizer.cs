using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propRandomizer : MonoBehaviour
{

    public List<GameObject> propSpawnPoints;
    public List<GameObject> propPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        spawnProps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnProps()
    {
        foreach (GameObject sp  in propSpawnPoints)
        {
            int rand = Random.Range(0, propPrefabs.Count);
            Instantiate(propPrefabs[rand], sp.transform.position, Quaternion.identity);
        }
    }
}
