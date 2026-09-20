using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentação : MonoBehaviour
{
    Vector2 input;
    public Rigidbody2D rb;
    public float velocidade;
    
    void Start()
    {
        
    }

    public void Input(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }

    void Update()
    {
        rb.linearVelocity = input * velocidade;
    }
}
