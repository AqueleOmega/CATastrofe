using UnityEngine;

public class Inimigo01 : MonoBehaviour
{
    float VidaMaxima = Variaveis.vida_max_inimigo1;
    float VidaAtual;
    float xp = Variaveis.xp_inimigo1;
    float velocidade = Variaveis.velocidade_inimigo1;
    public Rigidbody2D rb;
    public GameObject prefab_dano;
    public GameObject prefab_xp;
    public GameObject prefab_cura;
    Transform player_transform;

    void Start()
    {
        VidaAtual = VidaMaxima;
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Morte()
    { 
        int spawnCura = Random.Range(1,5);
        if (spawnCura == 4)
        {
            Instantiate(prefab_cura,transform.position,Quaternion.identity);
        }
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
        rb.linearVelocity = dist_norm * velocidade; //transform.right
    }
}
