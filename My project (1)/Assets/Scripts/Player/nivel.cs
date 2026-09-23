using UnityEngine;

public class nivel : MonoBehaviour
{
    public static void ChecarNivel()
    {
        while (Variaveis.xp >= Variaveis.levelup_xp)
        {
            Variaveis.xp -= Variaveis.levelup_xp;
            Variaveis.level++;
            Variaveis.vida += 1;
            Variaveis.dano_player +=  1;
            Variaveis.cooldown_bala = Variaveis.cooldown_bala / 1.10f;
            Debug.Log(Variaveis.cooldown_bala);
        }
    }
}


