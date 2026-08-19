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
        Quaternion myRotation = Quaternion.identity;
        myRotation.eulerAngles 
    }

    // Update is called once per frame
    void Update()
    {
        vector_dist = transform1.position - transform2.position;
        dist_norm = vector_dist.normalized;
        float m_Angle = Vector2.SignedAngle(Vector2.right, dist_norm); 
        myRotation.eulerAngles = new Vector3 (0,0,m_Angle)
        transform1.rotation.z = myRotation;

        Debug.Log(m_Angle);
        Debug.Log(vector_dist);
        Debug.Log(dist_norm);
    }
/*
    private void OnDrawGizmos(){
        vector_dist = transform1.position - transform2.position;
        Vector2 dist_norm = vector_dist.normalized;
        Gizmos.color = Color.yellow;
        //Gizmos.DrawLine(transform1.position, transform2.position);
        //Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector2.zero, dist_norm);
    }
    */
}
