using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public static Transform playerPos;
    private NavMeshAgent nav;
    private PlayerHealth playerHealth;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        playerHealth = EnemyManager.player.GetComponent<PlayerHealth>();
    }

    void Update()
    {
        nav.SetDestination(playerPos.position);
    }
}
