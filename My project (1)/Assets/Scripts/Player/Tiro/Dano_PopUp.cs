using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.InputSystem.Controls;

public class Dano_PopUp : MonoBehaviour
{

    public static void Create (Vector3 position, float Damage, GameObject pf_dano)
    {
        GameObject popup_danoTransform = Instantiate(pf_dano, Vector3.zero, Quaternion.identity);
        popup_danoTransform.transform.position = position;
        Dano_PopUp dano_script = popup_danoTransform.GetComponent<Dano_PopUp>();
        TextMeshPro textmesh = popup_danoTransform.GetComponent<TextMeshPro>();
        dano_script.Setup(Damage, textmesh);
        dano_script.StartCoroutine(dano_script.Animacao(popup_danoTransform));
    }
    

    public void Setup(float Damage, TextMeshPro textMesh)
    {
        textMesh.SetText(Damage.ToString());
    }

    IEnumerator Animacao(GameObject numero)
    {
        float tempo = 0;
        float variaçãox = Random.Range(-0.03f, 0.03f);
        while (tempo < 0.5)
        {
            yield return new WaitForFixedUpdate();
            numero.transform.position += new Vector3(variaçãox, 0.06f);
            variaçãox *= 0.99f;
            tempo += Time.deltaTime;
        }
        Destroy(numero);
    }
}
