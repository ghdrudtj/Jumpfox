using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu]
public class DataBaseManager : ScriptableObject
{
    public static DataBaseManager instance;
    [Header("�÷��̾�")]
    public float JumpPowerIncrease;
    public float GameOverYNeight = -10f;
    public int MoveSpeed;
    public float maxJumpPower;

    [Header("�÷���")]
    public Platform[] LargePlatformArr;
    public Platform[] MiddlePlatformArr;
    public Platform[] SmallPlatformArr;
    public PlatformManager.Data[] DataArr;

    public float GapIntervaMin = 5;
    public float GapIntervaMax = 8;
    public float GapX_Min = -3.45f;
    public float GapX_Max = 2.25f;

    [Header("������")]
    public item baseItem;
    public float itemSpawnPer;
    public int itemScore = 1;

    [Header("����")]
    public int MaxScore;

    [Header("����")]
    public int TrapSpeed;
    public int TrapActiveScore;

    [Header("����")]
    public Monster baseMonster;
    public float MonSpawnPer;
    public int MonMoveSpeed;

    [Header("���� �� �Ҹ�")]
    public Effect effect;
    public Score Score;
    public D_Effect D_effect;
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
