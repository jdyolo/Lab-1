using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 50;

    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("Enemy recibió " + damage + " de daño.");
        Debug.Log("Vida del Enemy: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy destruido.");
        Destroy(gameObject);
    }
}
