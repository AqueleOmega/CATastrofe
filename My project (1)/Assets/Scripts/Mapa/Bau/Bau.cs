using UnityEngine;
using System.Collections;

public class Bau : MonoBehaviour
{
    float distancia = 20;
    public GameObject bau;
    float segundos = 10;
    Transform player_transform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(SpawnBau());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBau()
    {
        while (true == true)
        {
            yield return new WaitForSeconds(segundos);
            float randomX = Random.Range(-100, 100);
            float randomY = Random.Range(-100, 100);

            Vector2 dist_norm = new Vector2(randomX,randomY).normalized * distancia;

            if (dist_norm == new Vector2 (0,0))
            {
                randomY = 10;
                dist_norm = new Vector2(randomX,randomY).normalized * distancia;
            }

            Vector2 dist_true = new Vector2(player_transform.position.x, player_transform.position.y) + dist_norm;

            Instantiate(bau, dist_true, transform.rotation);
        }
    }
}
