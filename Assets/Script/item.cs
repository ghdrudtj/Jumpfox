using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public static item instance;
    public int score = 1;
    public void Active(Vector2 pos, float halfSozeX )
    {
        transform.position = pos + new Vector2(Random.Range(-halfSozeX+1, halfSozeX-1), +2.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.totalScore += score;
            Destroy(gameObject);

            if (ScoreManager.instance.totalScore > ScoreManager.instance.BestScore)
            {
                ScoreManager.instance.BestScore = ScoreManager.instance.totalScore;
            }
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
