using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class RainLogic : MonoBehaviour
{

    [SerializeField] GameObject rainPrefab;
    // .one is the same as having Vector2(1, 1), so both values are set to one
    [SerializeField] Vector2 spawnSize = Vector2.one * 10; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRaindrop", 0.0f, 0.1f);
    }

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.red;
        Vector3 size = new Vector3(spawnSize.x, 0, spawnSize.y);
        Gizmos.DrawWireCube(transform.position, size * 2);
    }

    Vector3 GetRandomRaindropPos()
    {
        float x = Random.Range(-spawnSize.x, spawnSize.x);
        float z = Random.Range(-spawnSize.y, spawnSize.y);  // We use y since Vector2 only has 2 values: x and y

        Vector3 position = transform.position;
        position.x += x;
        position.z += z;
        position.y = 0.0f;

        return position;
    }

    void SpawnRaindrop()
    {
        GameObject dropGameObject = Instantiate(rainPrefab, GetRandomRaindropPos(), Quaternion.identity);
        Destroy(dropGameObject, 5.0f);
    }
}
