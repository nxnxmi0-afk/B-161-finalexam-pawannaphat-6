using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
  private float moveSpeed = 5f;
  private float JumpForce = 5f;

  private Rigidbody2D rb;

  void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  void Update()
    {
        float moveINput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveINput * moveSpeed,rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
        }
    }

    
}
