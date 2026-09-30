using UnityEngine;

public class TesteAura : MonoBehaviour
{
    public GameObject pfDano;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject popup_danoTransform = Instantiate(pfDano, Vector3.zero, Quaternion.identity);
        Dano_PopUp dano_script = popup_danoTransform.GetComponent<Dano_PopUp>();
        dano_script.Setup(20);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
