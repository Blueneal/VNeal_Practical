using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int score;
    public int maxHealth;
    private int currentHealth;
    private ScoreManager scoreManager;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int Damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= Damage;
        }
    }
}
