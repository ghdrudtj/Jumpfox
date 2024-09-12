using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player;
    private void Awake()
    {
        Player.Init();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
   
}
