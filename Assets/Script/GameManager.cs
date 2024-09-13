using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatformManager PlatformManager;
    private void Awake()
    {
        Player.Init();
        PlatformManager.Init();
    }
    void Start()
    {
        PlatformManager.Active();
    }

    void Update()
    {
        
    }
   
}
