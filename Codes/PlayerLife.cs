using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 500;
    public int currentHealth;

    public Text healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Make sure health doesn't go below 0 or above maxHealth
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Here you can implement what happens when the player dies
        Debug.Log("Player has died!");
        // For now, we'll simply disable the GameObject
        gameObject.SetActive(false);
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an enemy
        if (collision.gameObject.CompareTag("Enemy(Clone)"))
        {
            // Reduce player health
            TakeDamage(100); // You can adjust the damage amount as needed
        }
    }
}
