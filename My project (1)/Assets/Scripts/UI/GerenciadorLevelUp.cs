using System.Collections.Generic;
using UnityEngine;

public class GerenciadorLevelUp : MonoBehaviour
{
    public static GerenciadorLevelUp Instancia { get; private set; }
    [System.Serializable]
    public class OpcaoItem
    {
        public string idDoItem;
        public string nomeVisual;
        [TextArea] public string descricao;
    }

    [Header("Configuração de Itens")]
    public List<OpcaoItem> listaDeItens = new List<OpcaoItem>();
    [Header("Referências da UI")]
    public GameObject painelMenu;
    public List<BotaoEscolhaUI> botoes;
    private void Awake()
    {
        if (Instancia == null) Instancia = this;
    }
    public void AbrirMenu()
    {
        Time.timeScale = 0f; //Pausa o jogo
        List<OpcaoItem> pool = new List<OpcaoItem>(listaDeItens);
        for (int i = 0; i < botoes.Count; i++)
        {
            if (pool.Count > 0)
            {
                botoes[i].gameObject.SetActive(true);
                int rand = Random.Range(0, pool.Count);

                botoes[i].ConfigurarBotao(pool[rand], this);
                pool.RemoveAt(rand);
            }
            else
            {
                botoes[i].gameObject.SetActive(false);
            }
        }
        painelMenu.SetActive(true);
    }
    public void ItemSelecionado(OpcaoItem item)
    {
        switch (item.idDoItem)
        {
            case "ima":
                Variaveis.tamanho_coletor_xp += 1.0f;
                tamanho_circulo.Mudar_Alcance_XP(Variaveis.tamanho_coletor_xp);
                break;

            case "velocidade":
                Variaveis.velocidade_player += 1.2f;
                break;

            case "dano":
                Variaveis.dano_player += 5;
                break;
        }
        painelMenu.SetActive(false);
        Time.timeScale = 1f; // Despausa o jogo
    }
}