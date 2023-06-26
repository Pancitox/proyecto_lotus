using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  // Referencia al transform del jugador principal
    public float smoothSpeed = 0.5f;  // Velocidad de suavizado para seguir al jugador

    private Vector3 offset;  // Distancia inicial entre el sprite y el jugador

    void Start()
    {
        // Calcula la distancia inicial entre el sprite y el jugador
        offset = transform.position - player.position;
    }

    void Update()
    {
        // Calcula la posición objetivo del sprite, sumando la posición del jugador y el offset
        Vector3 targetPosition = player.position + offset;

        // Utiliza el suavizado para mover gradualmente el sprite hacia la posición objetivo
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

        // Actualiza la posición del sprite
        transform.position = smoothedPosition;
    }
}
