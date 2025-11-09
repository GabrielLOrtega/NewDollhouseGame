using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerprefab;

    [SerializeField]
    private Transform spawnArea;

    [SerializeField]
    private float swarmerInterval = 2.5f;
    [SerializeField]
    private List<GameObject> dustbunnies = new List<GameObject>();
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerprefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (dustbunnies.Count < 10) {
        yield return new WaitForSeconds(interval);

            int spawnCount = Random.Range(1, 4);
            GameObject newEnemy = Instantiate(
                enemy,
                GetRandomPosition(),
                Quaternion.identity
            );
            dustbunnies.Add(newEnemy);
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 center = spawnArea.position;
        Vector3 size = spawnArea.localScale;
        size *= 9;

        Debug.Log(center);
        Debug.Log(size);
        float x = Random.Range(center.x - size.x / 2, center.x + size.x / 2);
        float y = center.y + size.y / 1;
        float z = Random.Range(center.z - size.z / 2, center.z + size.z / 2);

        return new Vector3(x, y, z);
    }
}