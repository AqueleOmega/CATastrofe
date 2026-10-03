using UnityEngine;
using Unity.Mathematics;

public class IrAtePlayer : MonoBehaviour
{
    bool target = false;
    Transform player_transform;
    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (target == true)
        {
            player_transform = GameObject.FindGameObjectWithTag("Player").transform;
            Vector2 vector_dist = player_transform.position - transform.position;
            Vector2 dist_norm = vector_dist.normalized;
            float anguloRAD = Mathf.Atan2(dist_norm.y, dist_norm.x);
            float angulo_graus = anguloRAD * 180 / math.PI;
            transform.rotation = Quaternion.Euler(0, 0, angulo_graus);
            rb.linearVelocity = transform.right * Variaveis.velocidade_xp;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("XP_Circle"))
        {
            target = true;
        }
    }
}
