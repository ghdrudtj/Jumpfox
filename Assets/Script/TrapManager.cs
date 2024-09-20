using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    [SerializeField] private int TrapSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        if(ScoreManager.instance.totalScore >= 3)
        {
            this.transform.Translate(0, TrapSpeed * Time.deltaTime, 0);
        }
    }
}
