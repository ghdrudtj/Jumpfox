using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public float JumpPower;
    public float MoveSpeed = 3;
    private bool shouldRotate = false;
    public bool isFloor = false;
    public GameObject playerpos;

    int playerLayer, platformLayer;

    private Rigidbody2D rb;
    private Animator animator;
    public float pleyerY;

    [SerializeField] public GameObject rePalyBtn;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerLayer = LayerMask.NameToLayer("player");
        platformLayer = LayerMask.NameToLayer("platform");
    }
    internal void Init()
    {
        instance = this;
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
                JumpPower += DataBaseManager.instance.JumpPowerIncrease;
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
            // 180도 회전
            transform.Rotate(0, 180, 0);
            shouldRotate = false;
        }
        if (rb.velocity.y > 0)
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, true);
        else
            Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
    }
    public void PlayerMove()
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
        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            rePalyBtn.SetActive(true);
            Debug.Log("게임 오버 ");
        }
    }
}
