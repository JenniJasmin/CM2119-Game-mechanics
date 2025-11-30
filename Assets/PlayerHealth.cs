using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth = 3;

    public HealthUI healthUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthUI = GameObject.FindObjectsByType <HealthUI> (FindObjectsSortMode.None).First();
       // currentHealth = maxHealth;
       // healthUI.SetMaxHearts(maxHealth);
    }

   void OnCollisionEnter2D(Collision2D collision)
   {
    Enemy enemy = collision.gameObject.GetComponent <Enemy>();
    Debug.Log("collisionHappen");

    if (enemy)
    {
        TakeDamage(enemy.damage);
        Debug.Log("damageTaken");
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
