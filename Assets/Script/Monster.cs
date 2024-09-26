using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public static Monster instance;
    private Animator MonsterAnim;
    public bool MonRotate = false;
    public float minX; // 최소 x 좌표
    public float maxX; // 최대 x 좌표
    private void Start()
    {
        MonsterAnim = GetComponent<Animator>();
    }
    public void Active(Vector2 pos, float halfSozeX)
    {
        transform.position = pos + new Vector2(Random.Range(-halfSozeX + 1, halfSozeX - 1), +2.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            MonRotate = true;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            playerstop();
            MonsterAnim.SetTrigger("Attack");
            Invoke("playerplay", 1f);
        }
    }
    public void MonsterMove()
    {
        this.transform.Translate(DataBaseManager.instance.MonMoveSpeed * Time.deltaTime,0,0);
    }
    private void Update()
    {
        //MonsterMove();
        if (MonRotate)
        {
            // 180도 회전
            transform.Rotate(0, 180, 0);
            MonRotate = false;
        }
    }
    void playerstop()
    {
        Player.instance.isstop = true;
        Player.instance.animator.SetInteger("Jump", 1);
        Player.instance.Renderer.GetComponent<SpriteRenderer>().color = Color.gray;
    }
    void playerplay()
    {
        Player.instance.isstop = false;
        Player.instance.animator.SetInteger("Jump", 0);
        Player.instance.Renderer.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
