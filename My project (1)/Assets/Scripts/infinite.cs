using UnityEngine;

public class infinite : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; 
    [SerializeField] private float mapSize = 30f;       

    void Update()
    {
        if (playerTransform == null) return;

        float targetX = Mathf.Round(playerTransform.position.x / mapSize) * mapSize;
        float targetY = Mathf.Round(playerTransform.position.y / mapSize) * mapSize;

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}