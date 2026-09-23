using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    // Public variable creates an assignable slot in the Unity Inspector
    public GameObject bulletCloneTemplate;

    void Update()
    {
        // GetKeyDown fires once per press, preventing infinite spawns every frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn position -- Instantiate(original, positon, rotation)
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
    }
}