using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float fallSpeed = 3.0f;
    public GameObject coinPrefab; // El prefab de la moneda

    private void Update()
    {
        // Mueve la moneda hacia abajo en el eje Y
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Comprueba si el objeto que colisiona es el jugador
        {
            // Aquí puedes implementar la lógica de lo que sucede cuando el auto toca la moneda
            // Por ejemplo, aumentar la puntuación.

            // Luego, destruye la moneda actual
            Destroy(gameObject);

            // Instancia una nueva moneda en la parte superior de la pantalla
            SpawnNewCoin();
        }
    }

    private void SpawnNewCoin()
    {
        // Calcula una posición aleatoria en la parte superior de la pantalla
        float randomX = Random.Range(-2.5f, 2.5f); // Ajusta el rango según tu diseño
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0f); // Ajusta la altura según tu diseño

        // Instancia una nueva moneda en la posición calculada
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}


