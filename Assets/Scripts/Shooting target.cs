using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    [SerializeField] private float targetHealth = 100f;  // Health of the target
    [SerializeField] private float damageAmount = 10f;   // Damage to target when hit
    [SerializeField] private GameObject destructionEffect; // Effect when destroyed

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(damageAmount); // Call TakeDamage if hit by a bullet
        }
    }

    private void TakeDamage(float damage)
    {
        targetHealth -= damage;  // Subtract damage from health
        if (targetHealth <= 0)
        {
            DestroyTarget();  // Destroy the target if health is 0 or below
        }
    }

    private void DestroyTarget()
    {
        if (destructionEffect != null)
        {
            Instantiate(destructionEffect, transform.position, Quaternion.identity);  // Instantiate the destruction effect
        }

        Destroy(gameObject);  // Destroy the target object
    }
}
