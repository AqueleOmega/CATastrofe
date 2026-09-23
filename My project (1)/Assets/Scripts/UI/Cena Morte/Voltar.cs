using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltar : MonoBehaviour
{
    public void Jogo()
    {
        Reset();
        SceneManager.LoadScene(1);

    }

    public void Menu()
    {
        Reset();
        SceneManager.LoadScene(0);
    }

    void Reset() //TODA VARIAVEL NOVA COLOCAR AQUI
    {
        Variaveis.level = 0;
        Variaveis.xp = 0;
        Variaveis.dano_player = 10;
        Variaveis.vida = 20;
        Variaveis.velocidade_bala = 6;
        Variaveis.cooldown_bala = 3;
        Variaveis.velocidade_player = 5;
        Variaveis.levelup_xp = 10;

           //inimigos
        Variaveis.inimigos_maximos = 10;
        Variaveis.inimigos_atuais = 0;
        Variaveis.cooldowninimigos = 1;
        Variaveis.distancia_inimigos = 20;
        Variaveis.dano_inimigo = 5;
        Variaveis.xp_inimigo = 5;
        Variaveis.vida_max_inimigo = 20;
        Variaveis.velocidade_inimigo = 1;
    }
}
