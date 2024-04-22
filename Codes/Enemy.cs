using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject cubePrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-50, 41), 5, Random.Range(-50, 41));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
