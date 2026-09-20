using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Windows;

public class DebugMenu : MonoBehaviour
{
    bool input;
    public Text Tudo;
    int contagem = 0;
    int fonte_size = 300;

    void FixedUpdate()
    {
        Tudo.text = $"Level: {Variaveis.level}\n, XP: {Variaveis.xp}\n Vida: {Variaveis.vida}\n Dano: {Variaveis.dano_player}";
    }

    public void Menu()
    {
        contagem++;
        if (contagem == 1)
        {
            Tudo.fontSize = fonte_size;
        }
        else
        {
            contagem = 0;
            Tudo.fontSize = 0;
        }
    }


}
