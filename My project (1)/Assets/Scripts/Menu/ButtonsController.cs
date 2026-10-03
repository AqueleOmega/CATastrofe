using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject tudoParaDesativar;
    public GameObject painelCreditos;
    public GameObject botaoVoltarCreditos;

    public void JogarJogo()
    {
        if (TransitionManager.Instance != null)
        {
            TransitionManager.Instance.MudarDeCenaComFade("Jogo");
        }
        else
        {
            // Caso de segurança se o gerenciador não estiver na cena
            SceneManager.LoadScene("Jogo");
        }
    }

    public void AbrirCreditos()
    {
        painelCreditos.SetActive(true);
        if (tudoParaDesativar != null) tudoParaDesativar.SetActive(false);
        if (botaoVoltarCreditos != null) botaoVoltarCreditos.SetActive(false);
    }

    public void FecharCreditos()
    {
        painelCreditos.SetActive(false);
        if (tudoParaDesativar != null) tudoParaDesativar.SetActive(true);
    }

    public void MostrarBotaoVoltar()
    {
        botaoVoltarCreditos.SetActive(true);
    }

    public void SairDoJogo()
    {
        tudoParaDesativar.SetActive(false);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
