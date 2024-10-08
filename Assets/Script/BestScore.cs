using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "최고 점수: " + ScoreManager.instance.BestScore.ToString();
    }

    void Update()
    {
        
    }
}
