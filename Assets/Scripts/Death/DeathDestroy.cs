using System;
using UnityEngine;

public class DeathDestroy : Death
{
    public GameObject deathExplodePrefab;

    public override void Start()
    {
        
    }

    public override void Update()
    {
        
    }

    public override void Die()
    {
        if (deathExplodePrefab != null)
    {
        Instantiate(deathExplodePrefab, transform.position, Quaternion.identity);
    }
        Destroy(gameObject);
    }
}

