using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bala_Instanciada : MonoBehaviour
{
    public Rigidbody2D rb;
    float velocidade = Variaveis.velocidade_bala;
    Transform Inimigo;
    GameObject enemy;

    public void Chefe()
    {
        Inimigo = InimigoMaisPerto(); //pego o inimigo mais proximo
        Rotacionar(Inimigo); //rotaciono em direção dele
        rb.linearVelocity = transform.right * velocidade; //movo em direção do inimigo


    }
    public Transform InimigoMaisPerto()
    {

        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Enemy"); //pego todos os inimigos com a tag inimigo
        Transform inimigoMaisPerto = null;

        float menorDistancia = Mathf.Infinity;

        foreach (GameObject inimigo in inimigos) //cada inimigo em inimigos
        {
            float distancia = Vector2.Distance(transform.position, inimigo.transform.position); ; //literalmente a distancia

            if (distancia < menorDistancia) //se a distancia for menor que a menor distancia já registrada ela vira a menor distancia
            {
                menorDistancia = distancia;
                inimigoMaisPerto = inimigo.transform;
                enemy = inimigo;

            }
        }

        return inimigoMaisPerto;

    }
    void Rotacionar(Transform inimigo) //mesmo codigo do inimigo
    {

        Vector2 vector_dist = inimigo.position - transform.position;
        Vector2 dist_norm = vector_dist.normalized;

        float anguloRAD = Mathf.Atan2(dist_norm.y, dist_norm.x);
        float angulo_graus = anguloRAD * 180 / math.PI;

        transform.rotation = Quaternion.Euler(0, 0, angulo_graus);
    }



}
