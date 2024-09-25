using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu]
public class DataBaseManager : ScriptableObject
{
    public static DataBaseManager instance;
    [Header("플레이어")]
    public float JumpPowerIncrease;
    public float GameOverYNeight = -10f;
    public int MoveSpeed;
    public float minJumpPower;
    public float maxJumpPower;

    [Header("플랫폼")]
    public Platform[] LargePlatformArr;
    public Platform[] MiddlePlatformArr;
    public Platform[] SmallPlatformArr;
    public PlatformManager.Data[] DataArr;

    public float GapIntervaMin = 5;
    public float GapIntervaMax = 8;
    public float GapX_Min = -3.45f;
    public float GapX_Max = 2.25f;

    [Header("아이템")]
    public item baseItem;
    public float itemSpawnPer;
    public int itemScore = 1;
    public int MaxScore = 100;

    [Header("함정")]
    public int TrapSpeed;
    public int TrapActiveScore;

    [Header("몬스터")]
    public Monster baseMonster;
    public float MonSpawnPer;
    public int MonMoveSpeed;
    internal void Init()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
