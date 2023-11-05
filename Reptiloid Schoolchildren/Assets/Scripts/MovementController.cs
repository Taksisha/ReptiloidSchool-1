using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 7f;

    private float MoveX;
    private float MoveY;

    private SpriteRenderer sprite;

    private Animator animator;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        MoveX = Input.GetAxis("Horizontal");
        MoveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(MoveX * speed, MoveY * speed);


        bool isWalking = Mathf.Abs(MoveX) > 0.1f || Mathf.Abs(MoveY) > 0.1f;
        animator.SetBool("IsWalking", isWalking);

        if (MoveX < 0 && !sprite.flipX)
        {
            sprite.flipX = true; 
        }
       
        else if (MoveX > 0 && sprite.flipX)
        {
            sprite.flipX = false; 
        }
    }
}
