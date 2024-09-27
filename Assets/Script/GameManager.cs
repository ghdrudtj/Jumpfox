using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private Player Player;
    [SerializeField] private PlatformManager PlatformManager;
    [SerializeField] private CameraManager CameraManager;
    [SerializeField] private ScoreManager ScoreManager;
    [SerializeField] private DataBaseManager DataBaseManager;
    [SerializeField] public GameObject rePalyBtn;
    [SerializeField] public GameObject clearText;
    private float gameCount = 2;
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
        if(ScoreManager.instance.totalScore >= DataBaseManager.instance.MaxScore)
        {
            gameCount -= Time.deltaTime;
            clearText.SetActive(true);
            if(gameCount <= 0)
            {
                 SceneManager.LoadScene("End");
            }
        }
    }
    public void GameOver()
    {
        rePalyBtn.SetActive(true);
    }
    public void rePlay()
    {
        SceneManager.LoadScene("Main");
    }
        
}
