using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        Vector3 targetPos = player.position + new Vector3(0, 10, -8);

        transform.position = Vector3.Lerp(
            transform.position,
            targetPos,
            5f * Time.deltaTime
        );

        transform.LookAt(player);
    }
}
