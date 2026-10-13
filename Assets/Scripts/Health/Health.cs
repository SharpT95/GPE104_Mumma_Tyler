using UnityEngine;

public class Health : MonoBehaviour
{

    public float currentHealth;

    public float maxHealth;

    private Death death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        death=GetComponent<Death>();
    }

    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0 && death != null)
        {
            death.Die();
        }
    }
}
