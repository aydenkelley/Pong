using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    private float movement;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
         if(isPlayer1)
	 {
             movement = Input.GetAxisRaw("Vertical");
	 }
	 else
	 {
	     movement = Input.GetAxisRaw("Vertical2");
	 }
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, movement * speed); 
    }
}
