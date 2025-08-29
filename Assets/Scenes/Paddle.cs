using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    private float movement;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
         movement = Input.GetAxisRaw("Vertical");
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, movement * speed); 
    }
}
