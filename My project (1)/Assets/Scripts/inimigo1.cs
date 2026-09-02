using UnityEngine;

public class inimigo1 : MonoBehaviour
{
    public float VidaMaxima = 20f;
    public float dano1 = 0.1f;
    public float VidaAtual;
    void Start()
        {
            VidaAtual = VidaMaxima;
        }

    public void TomarDano (float DanoReal)
        {
        VidaAtual -= DanoReal;

        if (VidaAtual <= 0)
        {
            morrer();
        }
    }

    void morrer ()
    {
        Destroy(gameObject);
    }
}
