using UnityEngine;
using System.Collections.Generic;

public class InimigoMaisProximo : MonoBehaviour
{
    Transform player_transform;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<Vector2> distancias = new List<Vector2> {};
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
    // Criamos a lista para guardar as distâncias dos inimigos que entrarem no range
    List<Vector2> distancias = new List<Vector2>();

    // Pega a posição do transform que acabou de entrar no Trigger
    Transform transformIni = collisionInfo.transform;

    // Calcula a distância vetorial entre o player e o alvo (convertendo para Vector2)
    Vector2 playerPos = new Vector2(player_transform.position.x, player_transform.position.y);
    Vector2 inimigoPos = new Vector2(transformIni.position.x, transformIni.position.y);
    Vector2 distancia_at = playerPos - inimigoPos;

    // Guarda na lista
    distancias.Add(distancia_at);

    // Para ver os valores reais no Console do Unity:
    // .magnitude transforma o vetor (X, Y) em um número real (distância em metros)
    Debug.Log($"Vetor da Distância: {distancia_at}");
    Debug.Log("!");
    }
    
}
