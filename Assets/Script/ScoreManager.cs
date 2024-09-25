using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TextMeshProUGUI scoreTmp;
    [SerializeField] private Score baseScore;

    public int totalScore;
    public int BestScore;
    internal void Init()
    {
        instance = this;
    }
    public void AddScore(int score)
    {
        Debug.Log("ÇöÁ¡¼ö = " + totalScore);
    }
    void Start()
    {
        
    }
    void TotalScore()
    {
        scoreTmp.text = $"{totalScore}/{DataBaseManager.instance.MaxScore}".ToString();
    }
    void Update()
    {
        TotalScore();
    }
}
