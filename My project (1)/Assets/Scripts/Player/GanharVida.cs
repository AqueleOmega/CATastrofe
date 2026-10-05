using UnityEngine;

public class GanharVida : MonoBehaviour
{
    public static void Life_Change(float cura)
    {
        if (Variaveis.vida + cura > Variaveis.vida_max)
        {
            Variaveis.vida = Variaveis.vida_max;
        }
        else
        {
            Variaveis.vida += cura;
        }
    }
}
