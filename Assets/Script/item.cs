using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public static item instance;
    public int score = 1;
    public void Active(Vector2 pos, float halfSozeX )
    {
        transform.position = pos + new Vector2(Random.Range(-halfSozeX, halfSozeX), 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.totalScore += score;
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
