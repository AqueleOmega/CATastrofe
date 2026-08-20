using Unity.Mathematics;
using UnityEngine;

public class Rotaçãoteste : MonoBehaviour
{
    Transform player_transform;
    Transform rotationbala;
    Vector2 vector_dist;
    Vector2 dist_norm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        rotationbala = GameObject.FindGameObjectWithTag("RotationBala").transform;

    }

    // Update is called once per frame
    void Update()
    {
        vector_dist = player_transform.position - transform.position;
        dist_norm = vector_dist.normalized;
        float anguloRAD = Mathf.Atan2(dist_norm.y, dist_norm.x);
        float angulo_graus_ini = anguloRAD * 180 / math.PI;
        float angulo_graus_player = (anguloRAD * 180 / math.PI) + 180;
        transform.rotation = Quaternion.Euler(0, 0, angulo_graus_ini);
        rotationbala.rotation = Quaternion.Euler(0, 0, angulo_graus_player);
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
