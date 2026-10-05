using UnityEngine;

public class nivel : MonoBehaviour
{
    public static void ChecarNivel()
    {
        while (Variaveis.xp >= Variaveis.levelup_xp)
        {
            Variaveis.xp -= Variaveis.levelup_xp;
            Variaveis.level++;
            GanharVida.Life_Change(1);
            Variaveis.dano_player +=  1;
            Variaveis.cooldown_bala = Variaveis.cooldown_bala / 1.10f;
            Variaveis.tamanho_coletor_xp *= 1.10f;
            tamanho_circulo.Mudar_Alcance_XP(Variaveis.tamanho_coletor_xp);

        }
    }
}


