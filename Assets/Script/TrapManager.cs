using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(ScoreManager.instance.totalScore >= DataBaseManager.instance.TrapActiveScore)
        {
            this.transform.Translate(0, DataBaseManager.instance.TrapSpeed * Time.deltaTime, 0);
        }
    }
}
