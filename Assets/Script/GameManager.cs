using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatformManager PlatformManager;
    [SerializeField] private CameraManager CameraManager;
    private void Awake()
    {
        PlatformManager.Init();
        Player.Init();
        CameraManager.Init();   
    }
    void Start()
    {
        PlatformManager.Active();
    }

    void Update()
    {
        
    }
   
}
