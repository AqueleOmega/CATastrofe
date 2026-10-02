using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text cronometro;


    // Update is called once per frame
    void Update()
    {
        Variaveis.segundos += Time.deltaTime * 5;
        float tempoarrendodado = Mathf.CeilToInt(Variaveis.segundos);
        if (tempoarrendodado >= 60)
        {
            Variaveis.segundos -= 60;
            Variaveis.minutos += 1;
        }

        if (Variaveis.minutos == 0)
        {
            cronometro.text = "Tempo: " + tempoarrendodado + "s";
        }

        else
        {
            cronometro.text = "Tempo: " + Variaveis.minutos + "m" + tempoarrendodado + "s";
        }
            
    }
}
