using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gatilho : MonoBehaviour
{
    public GameObject modelo;
    public float cooldown = 3;
    Transform player_transform;
    Transform bala_transform;

    // Update is called once per frame
    void Start()
    {
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        bala_transform = GameObject.FindGameObjectWithTag("RotationBala").transform;
        StartCoroutine(Tempo());

    }

    IEnumerator Tempo()
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown); 
            //cada (cooldown) segundos executa a parte de baixo

            GameObject Tiro_INST = Instantiate(modelo, player_transform.position, Quaternion.Euler(0, 0, 0)); 
            //instancia uma bala baseado no mobelo(prefab) na posição do jogador e com rotação 0

            Bala_Instanciada tiro = Tiro_INST.AddComponent<Bala_Instanciada>();
            //adiciona a script 'bala instanciada' a bala, e colocamos o apelido tiro para ser possivel mexer nela via script Gatilho

            tiro.rb = Tiro_INST.GetComponent<Rigidbody2D>();
            //colocamos um rigidbody no objeto instaciado para ele conseguir se mover

            tiro.Chefe();
            //chamamos o metodo chefe no script instaciado


        }
    }
}

