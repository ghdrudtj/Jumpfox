using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private BoxCollider2D cof;
    internal void Active(Vector3 pos)
    {
        transform.position = pos;
        
            //Player.Instance.PlayerMove(transform.position, GatHelfSizeX());
    }
    public float GatHelfSizeY()
    {
        return cof.size.y * 0.5f;
    }
    public float GatHelfSizeX()
    {
        return cof.size.x * 0.5f;
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
