using UnityEngine;
using TMPro;

public class BotaoEscolhaUI : MonoBehaviour
{
    public TMP_Text textoNome;
    public TMP_Text textoDescricao;
    private GerenciadorLevelUp.OpcaoItem itemArmazenado;
    private GerenciadorLevelUp gerenciador;
    public void ConfigurarBotao(GerenciadorLevelUp.OpcaoItem item, GerenciadorLevelUp scriptGerenciador)
    {
        itemArmazenado = item;
        gerenciador = scriptGerenciador;
        textoNome.text = item.nomeVisual;
        textoDescricao.text = item.descricao;
    }
    public void AoClicarNoBotao()
    {
        gerenciador.ItemSelecionado(itemArmazenado);
    }
}