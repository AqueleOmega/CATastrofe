using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ColisãoPlayer : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Variaveis.vida -= Variaveis.dano_inimigo/100;
            Debug.Log(Variaveis.vida);
            if (Variaveis.vida < 0)
            {
                Morte();
            }
        }
    }

    void Morte()
    {
        SceneManager.LoadScene("Morte");
    }
}
