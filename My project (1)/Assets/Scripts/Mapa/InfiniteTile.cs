using UnityEngine;
public class InfiniteTile : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform[] chunks;
    private float blockSize = 25.6f;
    void LateUpdate()
    {
        if (playerTransform == null || chunks == null || chunks.Length == 0) return;
        foreach (Transform chunk in chunks)
        {
            if (chunk == null) continue;
            float diffX = chunk.position.x - playerTransform.position.x;
            float diffY = chunk.position.y - playerTransform.position.y;
            Vector3 newPosition = chunk.position;
            if (diffX < -blockSize * 1.5f) newPosition.x += blockSize * 3f;
            else if (diffX > blockSize * 1.5f) newPosition.x -= blockSize * 3f;
            if (diffY < -blockSize * 1.5f) newPosition.y += blockSize * 3f;
            else if (diffY > blockSize * 1.5f) newPosition.y -= blockSize * 3f;
            chunk.position = new Vector3(newPosition.x, newPosition.y, chunk.position.z);
        }
    }
}