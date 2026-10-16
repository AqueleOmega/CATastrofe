using UnityEngine;
using UnityEngine.UI;
using Unity.Mathematics;
using TMPro;

public class XP_Bar : MonoBehaviour
{
    public GameObject xp;
    float PorcentagemXP;
    public TMP_Text text;

    void Update()
    {
        // Cuida apenas da escala visual e do texto usando os dados limpos das Variaveis
        if (Variaveis.xp <= 0)
        {
            PorcentagemXP = 0;
        }
        else
        {
            PorcentagemXP = Mathf.Clamp01(Variaveis.xp / Variaveis.levelup_xp);
        }

        float Escala = PorcentagemXP * 8;

        text.text = Mathf.FloorToInt(Variaveis.xp) + "/" + Variaveis.levelup_xp;
        xp.transform.localScale = new Vector3(Escala, 0.33f, 1);
    }
}