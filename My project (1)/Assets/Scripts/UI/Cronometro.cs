using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text cronometro;
    float time = 55;
    float minutos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float tempoarrendodado = Mathf.CeilToInt(time);
        if (tempoarrendodado >= 60)
        {
            time -= 60;
            minutos += 1;
        }

        if (minutos == 0)
        {
            cronometro.text = "Tempo: " + tempoarrendodado + "s";
        }
        else
        {
            cronometro.text = "Tempo: " + minutos + "m" + tempoarrendodado + "s";
        }
            
    }
}
