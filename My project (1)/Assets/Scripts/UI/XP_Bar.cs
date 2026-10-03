using UnityEngine;
using Unity.UI;
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
        if (Variaveis.xp == 0)
        {
            PorcentagemXP = 0;
        }
        else
        {
            PorcentagemXP = Variaveis.xp / Variaveis.levelup_xp;
        }
        float Escala = PorcentagemXP * 8; //8 é a escala
        text.text = Variaveis.xp + "/" + Variaveis.levelup_xp;
        xp.transform.localScale = new Vector3(Escala,0.33f,1);
    }
}
