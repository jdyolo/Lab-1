using UnityEngine;
public class Player : MonoBehaviour
{
    public string playerName = "Juan";
    public int health = 100;
    public float speed = 5f;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.Translate(
            movement * speed * Time.deltaTime,
            0,
            0
        );
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("El jugador recibió " + damage + " de daño.");
        Debug.Log("Vida restante: " + health);
    }
}