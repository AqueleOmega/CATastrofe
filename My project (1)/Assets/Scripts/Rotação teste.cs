using UnityEngine;

public class Rotaçãoteste : MonoBehaviour
{
    public Transform transform1;
    public Transform transform2;
    Vector2 vector_dist;
    Vector2 dist_norm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform1);
        // Debug.Log(transform2);
        vector_dist = transform1.position - transform2.position;
        Debug.Log(vector_dist);
        Vector2 dist_norm = vector_dist.normalized;
        Debug.Log(dist_norm);
    }
    private void OnDrawGizmos(){
        Vector2 dist_norm = vector_dist.normalized;
        Gizmos.color = Color.yellow;
        //Gizmos.DrawLine(transform1.position, transform2.position);
        //Gizmos.color = Color.red;
        Gizmos.DrawLine(transform1.position, dist_norm);
    }
}
