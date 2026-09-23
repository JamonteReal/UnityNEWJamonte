using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // This is the speed of the bullet
    private float bulletSpeed = 20f;

    void Update()
    {
        // This implements the movement of the bullet - It'll move forward at the same speed regardless of FPS
        transform.position += bulletSpeed * transform.forward * Time.delta;
    }
}
