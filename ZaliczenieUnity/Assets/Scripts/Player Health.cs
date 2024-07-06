using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;
    private RespawnScript respawn;

    private void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RespawnScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

  
    public void TakeDamage (int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            transform.position = respawn.transform.position;
            health = maxHealth;
        }
    }
}
