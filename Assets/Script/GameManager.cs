using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatformManager PlatformManager;
    [SerializeField] private CameraManager CameraManager;
    [SerializeField] private Platform Platform;
    private void Awake()
    {
        Platform.Init();
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
