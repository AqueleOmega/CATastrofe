using UnityEngine;

public class DesabilitarCirculo : MonoBehaviour
{
    SpriteRenderer sr;
    int a = 0;
    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }
    public void Mudar()
    {
        a += 1;
        if (a == 1)
        {
            sr.enabled = true;
        }
        if (a == 2)
        {
            a = 0;
            sr.enabled = false;
        }
    }
}
