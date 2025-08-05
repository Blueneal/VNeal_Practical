using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float maxHealth = 100f;
    public float currentHealth;
    public Slider healthSlider;

    void Awake()
    {
        currentHealth = maxHealth;
        healthSlider.value = maxHealth;
    }

    public void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int Damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= Damage;
            healthSlider.value = currentHealth;
        }
    }

    public void Die()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
