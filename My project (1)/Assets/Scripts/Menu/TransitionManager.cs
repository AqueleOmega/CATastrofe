using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public static TransitionManager Instance { get; private set; }

    public CanvasGroup fadeCanvasGroup;
    public float duracaoDoFade = 1.0f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        StartCoroutine(ExecutarFadeIn());
    }
    public void MudarDeCenaComFade(string nomeDaCena)
    {
        StartCoroutine(ExecutarTransicao(nomeDaCena));
    }

    IEnumerator ExecutarTransicao(string nomeDaCena)
    {
        fadeCanvasGroup.gameObject.SetActive(true);
        float tempo = 0f;
        while (tempo < duracaoDoFade)
        {
            tempo += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(0f, 1f, tempo / duracaoDoFade);
            yield return null;
        }
        fadeCanvasGroup.alpha = 1f;
        AsyncOperation operacao = SceneManager.LoadSceneAsync(nomeDaCena);
        while (!operacao.isDone)
        {
            yield return null;
        }
        tempo = 0f;
        while (tempo < duracaoDoFade)
        {
            tempo += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(1f, 0f, tempo / duracaoDoFade);
            yield return null;
        }
        fadeCanvasGroup.alpha = 0f;
        fadeCanvasGroup.gameObject.SetActive(false);
    }

    IEnumerator ExecutarFadeIn()
    {
        fadeCanvasGroup.gameObject.SetActive(true);
        fadeCanvasGroup.alpha = 1f;
        float tempo = 0f;
        while (tempo < duracaoDoFade)
        {
            tempo += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(1f, 0f, tempo / duracaoDoFade);
            yield return null;
        }
        fadeCanvasGroup.alpha = 0f;
        fadeCanvasGroup.gameObject.SetActive(false);
    }
}