using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 10;

    public void Collect()
    {
        Debug.Log("Moneda recogida. Valor: " + value);

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Collect();
        }
    }
}