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
        float Escala = PorcentagemXP * 8; //8 é a escala que precisa para encher a tela, ent multiplica por 8 pra saber o quanto ocupa da tela

        text.text = Variaveis.xp + "/" + Variaveis.levelup_xp;
        xp.transform.localScale = new Vector3(Escala,0.33f,1);
    }
}
