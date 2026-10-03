using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MenuController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject menuOpcoes, rawImage;
    private Animator animatorRawImage;

    void Start()
    {
        rawImage.SetActive(false);
        animatorRawImage = rawImage.GetComponent<Animator>();
        // O código de Fade inicial foi removido daqui para não dar conflito!
    }

    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            rawImage.SetActive(true);
            videoPlayer.Play();
            animatorRawImage.SetTrigger("FadeIn");
            menuOpcoes.SetActive(true);
        }
    }
}
