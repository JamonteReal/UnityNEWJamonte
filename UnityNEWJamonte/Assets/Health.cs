using UnityEngine;
using UnityEngine.Assemblies;

public class Health : MonoBehaviour
{
    // This is the health of the object
    private int maxHitPoints = 100;
    private int currentHitPoints = 100;

    // Call this to apply damage
    public void TakeDamage(int damageAmount)
    {
        currentHitPoints -= damageAmount;

        // Target is destroyed when health reaches zero
        if (currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}



