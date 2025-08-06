using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int scoreValue;
    public int maxHealth;
    private int currentHealth;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            ScoreManager.score += scoreValue;
            ScoreManager.instance.CurrentScore();
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
