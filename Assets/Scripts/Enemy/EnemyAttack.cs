using System.Threading;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float timer;
    private float attackCoolDown = 0.5f;
    private bool inRange;
    private PlayerHealth playerHealth;
    public int damage;

    private void Awake()
    {
        playerHealth = EnemyManager.player.GetComponent<PlayerHealth>();

    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (inRange && timer > attackCoolDown)
        {
            Attack();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == EnemyManager.player)
        {
            inRange = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == EnemyManager.player)
        {
            inRange = false;
        }
    }

    public void Attack()
    {
        timer = 0;
        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
