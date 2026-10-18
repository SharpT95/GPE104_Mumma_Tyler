using UnityEngine;

public class Damager : MonoBehaviour
{
    public float damageAmount;

    public Health otherHealthComponent;

    public bool isInstaKill;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        otherHealthComponent = collision.GetComponent<Health>();

        if (otherHealthComponent != null)
        {
            if (isInstaKill)
            {
                otherHealthComponent.TakeDamage(otherHealthComponent.maxHealth);
            }
            else
            {
                otherHealthComponent.TakeDamage(damageAmount);
            }
            Destroy(gameObject);
        }
    }
}
