using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmerprefab;
    [SerializeField] private Transform spawnArea;
    [SerializeField] private Transform player; //  Reference to the player
    [SerializeField] private float swarmerInterval = 2.5f;
    [SerializeField] private List<GameObject> dustbunnies = new List<GameObject>();

    public List<GameObject> Dustbunnies { get => dustbunnies; set => dustbunnies = value; }

    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerprefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (Dustbunnies.Count < 10)
        {
            yield return new WaitForSeconds(interval);

            if (IsPlayerOnSpawnPlane()) //  Check player presence
            {
                int spawnCount = Random.Range(1, 4);
                for (int i = 0; i < spawnCount && Dustbunnies.Count < 10; i++)
                {
                    GameObject newEnemy = Instantiate(
                        enemy,
                        GetRandomPosition(),
                        Quaternion.identity
                    );
                    Dustbunnies.Add(newEnemy);
                }
            }
        }
    }

    private bool IsPlayerOnSpawnPlane()
    {
        Vector3 center = spawnArea.position;
        Vector3 size = spawnArea.localScale * 9;

        Vector3 playerPos = player.position;

        bool withinX = playerPos.x >= center.x - size.x / 2 && playerPos.x <= center.x + size.x / 2;
        bool withinZ = playerPos.z >= center.z - size.z / 2 && playerPos.z <= center.z + size.z / 2;
        bool nearY = Mathf.Abs(playerPos.y - center.y) < 1.0f; //  Tolerance for vertical alignment

        return withinX && withinZ && nearY;
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 center = spawnArea.position;
        Vector3 size = spawnArea.localScale * 9;

        float x = Random.Range(center.x - size.x / 2, center.x + size.x / 2);
        float y = center.y + size.y / 1;
        float z = Random.Range(center.z - size.z / 2, center.z + size.z / 2);

        return new Vector3(x, y, z);
    }
}
