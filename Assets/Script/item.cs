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
            Player.instance.I_audioSource.Play();
            ScoreManager.instance.AddScore(score);

            if (ScoreManager.instance.totalScore > ScoreManager.instance.BestScore)
            {
                ScoreManager.instance.BestScore = ScoreManager.instance.totalScore;
                PlayerPrefs.SetInt("BestScore", ScoreManager.instance.BestScore); // 새로운 최고 점수 저장
                PlayerPrefs.Save();
                Debug.Log("새로운 최고 점수 = " + ScoreManager.instance.BestScore);
            }

            Score Score = Instantiate(DataBaseManager.instance.Score);
            Score.Active(transform.position);

            Destroy(gameObject);
        }
        
    }
    
    void Start()
    {
        instance = this;
        PlayerPrefs.SetInt("BestScore", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
            
        
    }
}
