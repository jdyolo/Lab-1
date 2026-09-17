using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 25;

    void Update()
    {
        transform.Translate(
            Vector3.right * speed * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);

            Debug.Log("La bala golpeó al Enemy.");

            Destroy(gameObject);
        }
    }
}
