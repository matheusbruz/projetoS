using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    Rigidbody2D rb;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Dependente de FrameRate
    void Update()
    {
        inputManagement();
    }
    
    // Independente de FrameRate
    private void FixedUpdate()
    {
        pMove();
    }

    void inputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2 (moveX, moveY).normalized;

        if(moveDir.x != 0)
        {
            lastHorizontalVector = moveDir.x;
        }

        if(moveDir.y != 0)
        {
            lastVerticalVector = moveDir.y;
        }
    }

    void pMove() 
    {
        rb.velocity = new Vector2 (moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }

}
