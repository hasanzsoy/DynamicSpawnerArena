using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0, 3, -6);
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player == null) return;

        // Player'ın arkasını baz al
        Vector3 desiredPosition = player.position + player.TransformDirection(offset);

        // Yumuşak takip
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        // Player'a bak
        transform.LookAt(player);
    }
}
