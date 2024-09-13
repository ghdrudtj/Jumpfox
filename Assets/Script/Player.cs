using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpPower;
    public float MoveSpeed = 3;
    private bool shouldRotate = false;
    public bool isFloor = false;

    int playerLayer, platformLayer;

    private Rigidbody2D rb;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerLayer = LayerMask.NameToLayer("player");
        platformLayer = LayerMask.NameToLayer("platform");
    }
    internal void Init()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (isFloor)
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                animator.SetInteger("Jump", 0);
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                JumpPower += 0.1f;
                animator.SetInteger("Jump", 1);
            }
            else if(Input.GetKeyUp(KeyCode.Space))
            {
                isFloor = false;
                rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
                animator.SetInteger("Jump", 2);
                JumpPower = 0;
            } 
        }
        Invoke("PlayerMove", 1f);
        if (shouldRotate)
        {
            // 180µµ È¸Àü
            transform.Rotate(0, 180, 0);
            shouldRotate = false;
        }
        if (rb.velocity.y > 0)
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, true);
        else
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
    }
    private void PlayerMove()
    {
        this.transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            shouldRotate = true;
        }
        if (collision.gameObject.CompareTag("platform"))
        {
            animator.SetInteger("Jump", 0);
            isFloor = true;
        }
    }
}
