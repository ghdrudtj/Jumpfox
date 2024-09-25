using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public static Monster instance;
    public bool MonRotate = false;
    public float minX; // 최소 x 좌표
    public float maxX; // 최대 x 좌표

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
            Invoke("playerplay", 0.5f);
        }
    }
    public void MonsterMove()
    {
        float newX = transform.position.x + DataBaseManager.instance.MonMoveSpeed * Time.deltaTime;

        // x 좌표를 제한
        newX = Mathf.Clamp(newX, minX, maxX);

        transform.position = new Vector2(newX, transform.position.y); 
    }
    private void Update()
    {
        MonsterMove();
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
        Player.instance.Renderer.GetComponent<SpriteRenderer>().color = Color.gray;
    }
    void playerplay()
    {
        Player.instance.isstop = false;
        Player.instance.Renderer.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
