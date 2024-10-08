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
    public int BestScore = 0;
    internal void Init()
    {
        if (instance == null)
        {
            instance = this;
            LoadBestScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void LoadBestScore()
    {
        BestScore = PlayerPrefs.GetInt("BestScore",0); // ����� �ְ� ���� �ҷ����� (�⺻�� 0)
        Debug.Log("�ְ� ���� �ε�: " + BestScore);
    }
    public void AddScore(int score)
    {
        totalScore += score;

        Debug.Log("������ = " + totalScore);
       
    }
    void Start()
    {
        PlayerPrefs.SetInt("BestScore", 0);
        PlayerPrefs.Save();
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
