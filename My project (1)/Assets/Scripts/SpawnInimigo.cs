using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    
    Transform player_transform;

    float cooldown = 0.1f;
    float distancia = 30;
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
        float inimigos = 0;
        Debug.Log("Foi");
        
        while (true)
        {
            yield return new WaitForSeconds(cooldown);
            float randomX = Random.Range(-100, 100);
            float randomY = Random.Range(-100, 100);
            Vector2 dist_norm = new Vector2(randomX,randomY).normalized * distancia;
            if (dist_norm == new Vector2 (0,0)){
                randomY = 10;
                dist_norm = new Vector2(randomX,randomY).normalized;
            }
            Debug.Log(randomX);
            Debug.Log(randomY);
            Debug.Log(dist_norm);
            Vector2 dist_true = new Vector2(player_transform.position.x, player_transform.position.y) + dist_norm;
            Debug.Log(dist_true);
            if (inimigos < 100){
                GameObject Inimigo = Instantiate(prefab, dist_true, transform.rotation);
                inimigos += 1;
            }
        

        }
    }
}
