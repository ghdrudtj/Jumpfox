using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    public void Active(Vector3 pos)
    {
        transform.position = pos;
    }
    public void CallAni1()
    {
        Debug.Log("GameObject�� �ı��մϴ�");
        Destroy(gameObject);
    }
    
}
