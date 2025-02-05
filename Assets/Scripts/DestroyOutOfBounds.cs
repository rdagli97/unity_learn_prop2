using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds = -10f;

    private void Update()
    {
        if (transform.position.z > topBounds || transform.position.z < lowerBounds)
            Destroy(gameObject);
    }
}
