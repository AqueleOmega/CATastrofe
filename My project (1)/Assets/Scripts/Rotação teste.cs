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

    }

    // Update is called once per frame
    void Update()
    {
        vector_dist = player_transform.position - transform.position;
        dist_norm = vector_dist.normalized;
        float anguloRAD = Mathf.Atan2(dist_norm.y, dist_norm.x);
        float angulo_graus_ini = anguloRAD * 180 / math.PI;
        transform.rotation = Quaternion.Euler(0, 0, angulo_graus_ini);
    }
}
