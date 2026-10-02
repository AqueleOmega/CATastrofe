using UnityEngine;

public class Inimigo02 : MonoBehaviour
{
    float VidaMaxima = Variaveis.vida_max_inimigo2;
    float VidaAtual;
    float xp = Variaveis.xp_inimigo2;
    float velocidade = Variaveis.velocidade_inimigo2;
    public Rigidbody2D rb;
    public GameObject prefab_dano;

    void Start()
    {
        VidaAtual = VidaMaxima;
    }

    void Morte()
    {
        Destroy(gameObject);
        Variaveis.xp += xp;
        nivel.ChecarNivel();
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
        rb.linearVelocity = transform.right * velocidade;
    }
}
