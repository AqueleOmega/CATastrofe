using UnityEngine;

public class Inimigo : MonoBehaviour
{
    float VidaMaxima = Variaveis.vida_max_inimigo;
    float VidaAtual;
    float xp = Variaveis.xp_inimigo;
    float velocidade = Variaveis.velocidade_inimigo;
    public Rigidbody2D rb;

    void Start()
    {
        VidaAtual = VidaMaxima;
    }

    void Morte()
    {
        Destroy(gameObject);
        Variaveis.xp += xp;
        Variaveis.inimigos_atuais -= 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Bala"))
        {
            Destroy(col.gameObject);
            VidaAtual -= Variaveis.dano_player;
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
