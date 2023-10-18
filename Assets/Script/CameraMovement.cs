using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Vector2 minBounds; // Batas minimum kamera (x, y)
    [SerializeField] private Vector2 maxBounds; // Batas maksimum kamera (x, y)

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        // Mengkompensasi batas bawah ground
        float clampedX = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

    }
}