using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // This is the speed of the bullet
    private float bulletSpeed = 20f;

    void Update()
    {
        // This implements the movement of the bullet - It'll move forward at the same speed regardless of FPS
        transform.position += bulletSpeed * transform.forward * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Looks for a Health component on the object that the bullet collided with
        Health possibleVictim = collision.transform.GetComponent<Health>();

        // If the object has a Health component, apply damage
        if (possibleVictim != null)
        {
            possibleVictim.TakeDamage(25); // Apply 25 damage to the object
        }
    }
}
