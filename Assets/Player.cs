using UnityEngine;

public class Player : MonoBehaviour
{
    public float Movespeed {get; private set;}
    public bool IsInvulnerable {get; private set;}


    private float moveSpeed = 5f;
    private float jumpForce = 10f;   

    private Rigidbody2D rb;




    public void SetMoveSpeed(float newSpeed)
    { 

        Movespeed = newSpeed;

        Debug.Log($"Player speed is {Movespeed}");
    
    }


    public void SetInerability(bool isEnabled)
    { 

        IsInvulnerable = isEnabled;
    
    }





    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                    
        }


    }
}
