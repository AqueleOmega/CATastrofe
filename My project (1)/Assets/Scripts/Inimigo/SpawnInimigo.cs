using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    
    Transform player_transform;

    float cooldown = Variaveis.cooldowninimigos;
    float distancia = Variaveis.distancia_inimigos;
    float quantia_maxima = Variaveis.inimigos_maximos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(spawn(cooldown));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawn(float cooldown)
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown);

            float randomX = Random.Range(-100, 100);
            float randomY = Random.Range(-100, 100);

            Vector2 dist_norm = new Vector2(randomX,randomY).normalized * distancia;

            if (dist_norm == new Vector2 (0,0))
            {
                randomY = 10;
                dist_norm = new Vector2(randomX,randomY).normalized;
            }

            Vector2 dist_true = new Vector2(player_transform.position.x, player_transform.position.y) + dist_norm;


            if (Variaveis.inimigos_atuais < quantia_maxima)
            {
                GameObject Inimigo = Instantiate(prefab, dist_true, transform.rotation);
                Variaveis.inimigos_atuais += 1;
            }
        

        }
    }
}
