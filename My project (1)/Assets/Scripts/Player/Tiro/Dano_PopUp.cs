using UnityEngine;
using TMPro;

public class Dano_PopUp : MonoBehaviour
{
    TextMeshPro textMesh;

    public static void Create (Vector3 position, float Damage, GameObject pf_dano)
    {
        GameObject popup_danoTransform = Instantiate(pf_dano, Vector3.zero, Quaternion.identity);
        Dano_PopUp dano_script = popup_danoTransform.GetComponent<Dano_PopUp>();
        dano_script.Setup(20);
    }
    
    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void Setup(int Damage)
    {
        textMesh.SetText(Damage.ToString());
    }
}
