using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Bau_Mestre : MonoBehaviour
{
    public GameObject painel_bau;
    public void AbrirBau()
    {
        Time.timeScale = 0;
        painel_bau.SetActive(true);
        
    }
    public void FecharBau()
    {
        painel_bau.SetActive(false);
        Time.timeScale = 1;
    }

    public void Cura()
    {
        GanharVida.Life_Change(4);
    }
}
