using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ColisãoPlayer : MonoBehaviour
{
    public Bau_Mestre scriptBau;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Variaveis.vida -= Variaveis.dano_inimigo1 / 100;
            if (Variaveis.vida < 0)
            {
                Morte();
            }
        }

        //xps
        if (collision.gameObject.CompareTag("XP"))
        {
            Variaveis.xp += Variaveis.orbe_1;
            //nivel.ChecarNivel();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("XP2"))
        {
            Variaveis.xp += Variaveis.orbe_2;
            //nivel.ChecarNivel();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("XP3"))
        {
            Variaveis.xp += Variaveis.orbe_3;
            //nivel.ChecarNivel();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Cura"))
        {
            GanharVida.Life_Change(4);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Bau"))
        {
            scriptBau.AbrirBau();

            Destroy(collision.gameObject);
        }
    }
    void Morte()
    {
        SceneManager.LoadScene("Morte");
    }
}