using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private BoxCollider2D cof;
    internal void Active(Vector2 pos)
    {
        transform.position = pos;
    }
    public float GatHelfSizeY()
    {
        return cof.size.y * 0.5f;
    }
    private void Awake()
    {
        cof = GetComponentInChildren<BoxCollider2D>();
    }
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
