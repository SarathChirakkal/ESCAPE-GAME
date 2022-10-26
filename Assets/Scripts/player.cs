using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
     public Rigidbody2D rb; 
    public float yVelocity;
     private float dirX;
     public float Speed;
      private CircleCollider2D col;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
          col = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump" )  && isGrounded())
        {
            rb.velocity = new Vector2(0,yVelocity);
        }
          dirX = Input.GetAxisRaw("Horizontal");
           rb.velocity = new Vector2(dirX * Speed , rb.velocity.y);

    }
    private bool isGrounded(){
        return Physics2D.BoxCast(col.bounds.center,col.bounds.size,0,Vector2.down,.2f,groundLayer);

    }

}
