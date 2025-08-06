using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> enemiesSpawned = new List<GameObject>();

    public static GameObject player;
    public PlayerHealth playerHealth;
    private GameObject enemy;
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public GameObject boss;
    public Transform[] spawnPoints;
    public int spawnTime = 3;

    private bool noBoss = true;
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
        int randomEnemy = Random.Range(0, 3);

        if (randomEnemy == 0)
        {
            enemy = cube;
            enemiesSpawned.Add(enemy);
        }
        else if (randomEnemy == 1)
        {
            enemy = sphere;
            enemiesSpawned.Add(enemy);
        }
        else if (randomEnemy == 2)
        {
            enemy = capsule;
            enemiesSpawned.Add(enemy);
        }
        
        Instantiate(enemy, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }

    public void Update()
    {
        if (ScoreManager.score >= 50 && noBoss)
        {
            foreach (GameObject enemy in enemiesSpawned)
            {
                Destroy(gameObject);
            }

            BossFight();
        }
    }

    private void BossFight()
    {
        GameObject spawnedEnemies = GameObject.FindGameObjectWithTag("Enemy");
        Destroy(spawnedEnemies);
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        float offsetY = transform.position.y + 1f;
        Instantiate(boss, spawnPoints[spawnIndex].position * offsetY, spawnPoints[spawnIndex].rotation);
        CancelInvoke();
    }
}
