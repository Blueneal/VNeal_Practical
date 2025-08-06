using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
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
            Debug.Log("You Win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
