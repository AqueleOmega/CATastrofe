using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ColisãoPlayer : MonoBehaviour
{
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
            nivel.ChecarNivel();
            ChamarMenuSeUpo();   //abre a interface se o nível subiu!
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("XP2"))
        {
            Variaveis.xp += Variaveis.orbe_2;
            nivel.ChecarNivel();
            ChamarMenuSeUpo();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("XP3"))
        {
            Variaveis.xp += Variaveis.orbe_3;
            nivel.ChecarNivel();
            ChamarMenuSeUpo();
            Destroy(collision.gameObject);
        }
    }

    //verifica e abre o menu de escolha de itens na hora da colisão
    private void ChamarMenuSeUpo()
    {
        GerenciadorLevelUp gerenciador = GerenciadorLevelUp.Instancia;
        if (gerenciador == null)
        {
            gerenciador = Object.FindFirstObjectByType<GerenciadorLevelUp>();
        }

        if (gerenciador != null)
        {
            gerenciador.AbrirMenu();
        }
        else
        {
            Debug.LogError("O script GerenciadorLevelUp não foi encontrado na cena!");
        }
    }
    void Morte()
    {
        SceneManager.LoadScene("Morte");
    }
}