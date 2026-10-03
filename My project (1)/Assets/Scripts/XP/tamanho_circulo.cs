using UnityEngine;

public class tamanho_circulo : MonoBehaviour
{
    void Start()
    {
        transform.localScale = new Vector3(Variaveis.tamanho_coletor_xp, Variaveis.tamanho_coletor_xp, Variaveis.tamanho_coletor_xp);
    }
    public static void Mudar_Alcance_XP(float tamanho)
    {
        GameObject Circulo = GameObject.FindGameObjectWithTag("XP_Circle");
        Circulo.transform.localScale = new Vector3(tamanho,tamanho,tamanho);
    }
}
