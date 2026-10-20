using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float currentHealth;

    public float maxHealth;

    private Death death;

    public Image healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        death=GetComponent<Death>();

        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }

    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

         if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

         if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }

        if (currentHealth <= 0 && death != null)
        {
            death.Die();
        }
    }
}
