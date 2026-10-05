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
        Variaveis.tempo_popup_dano_na_tela = 0.5f;
        Variaveis.vida = 10;
        Variaveis.vida_max = 10;
        Variaveis.velocidade_bala = 6;
        Variaveis.cooldown_bala = 3;
        Variaveis.velocidade_player = 5;
        Variaveis.levelup_xp = 10;
        Variaveis.tamanho_coletor_xp = 3;

        Variaveis.segundos = 0;
        Variaveis.minutos = 0;
        Variaveis.acel_tempo = 1;

        Variaveis.inimigos_maximos = 10;
        Variaveis.inimigos_atuais = 0;
        Variaveis.cooldowninimigos = 1;
        Variaveis.distancia_inimigos = 20;
          
        Variaveis.dano_inimigo1 = 5;
        Variaveis.xp_inimigo1 = 5;
        Variaveis.vida_max_inimigo1 = 20;
        Variaveis.velocidade_inimigo1 = 1;

        Variaveis.dano_inimigo2 = 5;
        Variaveis.xp_inimigo2 = 5;
        Variaveis.vida_max_inimigo2 = 20;
        Variaveis.velocidade_inimigo2 = 1;

        Variaveis.dano_inimigo3 = 5;
        Variaveis.xp_inimigo3 = 5;
        Variaveis.vida_max_inimigo3 = 20;
        Variaveis.velocidade_inimigo3 = 1;
    }
}
