using UnityEngine;

public class Inimigo3 : MonoBehaviour
{
    float VidaMaxima = Variaveis.vida_max_inimigo3;
    float VidaAtual;
    float xp = Variaveis.xp_inimigo3;
    float velocidade = Variaveis.velocidade_inimigo3;
    public Rigidbody2D rb;
    public GameObject prefab_dano;
    public GameObject prefab_xp;
    Transform player_transform;

    void Start()
    {
        VidaAtual = VidaMaxima;
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Morte()
    {
        Destroy(gameObject);
        Instantiate(prefab_xp, transform.position, Quaternion.identity);
        Variaveis.inimigos_atuais -= 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Bala"))
        {
            Destroy(col.gameObject);
            float dano = Mathf.RoundToInt(Random.Range(Variaveis.dano_player / 1.20f, Variaveis.dano_player * 1.20f));
            VidaAtual -= dano;
            Dano_PopUp.Create(transform.position, dano, prefab_dano);
            if (VidaAtual <= 0)
            {
                Morte();
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 vector_dist = player_transform.position - transform.position;
        Vector2 dist_norm = vector_dist.normalized;
        rb.linearVelocity = dist_norm * velocidade;
    }
}
