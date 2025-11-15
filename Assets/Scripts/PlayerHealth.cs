using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth=maxHealth;
    }

    public void TakeDamage(int amount) // 1 damage from most enemies
    {
        currentHealth = currentHealth - amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // just in case we add fractional damage
        if (currentHealth <= 0) 
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Heal()
    {
        currentHealth = maxHealth;
    }

}
