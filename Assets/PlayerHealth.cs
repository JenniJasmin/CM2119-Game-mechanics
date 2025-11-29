using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public HealthUI healthUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetMaxHearts(maxHealth);
    }

   private void OnTrigger2D(Collider2D collision)
   {
    Enemy enemy = collision.GetComponent<Enemy>();
    if (enemy)
    {
        TakeDamage(enemy.damage);
    }
   }

   private void TakeDamage(int damage)
   {
    currentHealth -= damage;
    healthUI.UpdateHearts(currentHealth);

    if(currentHealth <= 0)
    {
        //player dead! game over etc
    }
   }
}
