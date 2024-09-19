using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    [SerializeField] private GameObject player;
    internal void Init()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (player != null)
        {
            player =GameObject.FindGameObjectWithTag("Player");
        }
        transform.position = new Vector3(0, Player.instance.playerpos.transform.position.y + 3f, -10) ;
        
    }
}
