using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical"); // Captura la entrada vertical
        Vector2 movement = new Vector2(0f, verticalInput * speed * Time.deltaTime); // Utiliza la entrada vertical para el movimiento vertical
        transform.Translate(movement);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            // Aquí puedes implementar la lógica de lo que sucede cuando el auto toca la moneda
            // Por ejemplo, aumentar la puntuación y destruir la moneda.
            Destroy(other.gameObject);
        }
    }

}

