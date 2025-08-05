using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static GameObject player;
    public PlayerHealth playerHealth;
    private GameObject enemy;
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public Transform[] spawnPoints;
    public int spawnTime = 3;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EnemyMovement.playerPos = player.transform;
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Spawn()
    {
        if (playerHealth.currentHealth <= 0)
        {
            return;
        }

        int spawnIndex = Random.Range(0, spawnPoints.Length);
        int randomEnemy = Random.Range(0, 2);

        if (randomEnemy == 0)
        {
            enemy = cube;
        }
        else if (randomEnemy == 1)
        {
            enemy = sphere;
        }
        else if (randomEnemy == 2)
        {
            enemy = capsule;
        }
        
        Instantiate(enemy, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
