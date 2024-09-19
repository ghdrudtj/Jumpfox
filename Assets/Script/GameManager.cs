using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private PlatformManager PlatformManager;
    [SerializeField] private CameraManager CameraManager;
    [SerializeField] private ScoreManager ScoreManager;
    [SerializeField] private DataBaseManager DataBaseManager;
    
    private void Awake()
    {
        DataBaseManager.Init();
        Player.Init();
        PlatformManager.Init();
        CameraManager.Init();   
        ScoreManager.Init();
    }
    void Start()
    {
        PlatformManager.Active();
    }

    void Update()
    {
        
    }
   
}
