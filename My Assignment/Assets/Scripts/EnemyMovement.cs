using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private Vector3 moveDirection = Vector3.forward;
    
    private void Start()
    {
        // Normalize the direction to ensure consistent speed regardless of direction magnitude
        moveDirection = moveDirection.normalized;
    }

    private void Update()
    {
        // Move the enemy in the specified direction
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
