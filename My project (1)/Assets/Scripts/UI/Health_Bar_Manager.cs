using UnityEngine;
using TMPro;

public class Health_Bar_Manager : MonoBehaviour
{
    public GameObject vida;
    float PorcentagemVida;


    void Update()
    {
        if (Variaveis.vida < 0)
        {
            //isso aqui eh pra filtar caso a vida seja negativa
            PorcentagemVida = 0;
        }
        else
        {
            PorcentagemVida = Variaveis.vida / Variaveis.vida_max;
        }
        vida.transform.localScale = new Vector3(PorcentagemVida,0.33f,1);
    }
}
