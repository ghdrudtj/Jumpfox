using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [System.Serializable]
    public class Data
    {
        public int GroupCount;
        public float LargePercent;
        public float MiddlePercent;
        public float SmallPercent;
        public int GetPlatformID()
        {
            float ranVal = Random.value;
            int platformID;
            if(ranVal <= LargePercent)
            {
                platformID = 2;
            }
            else if(ranVal <= LargePercent+MiddlePercent)
            {
                platformID = 1;
            }
            else
            {
                platformID = 0;
            }
            return platformID;
        }
    }
    public static PlatformManager instance; 
    [SerializeField] private Transform SpawnPosTrf;
    [SerializeField] private Platform[] LargePlatformArr;
    [SerializeField] private Platform[] MiddlePlatformArr;
    [SerializeField] private Platform[] SmallPlatformArr;
    [SerializeField] private Data[] DataArr;
    private int platformNum;

    [SerializeField] private float GapIntervaMin = 5;
    [SerializeField] private float GapIntervaMax = 8;

    [SerializeField] private float GapX_Min = -3.45f;
    [SerializeField] private float GapX_Max = 2.25f;
   
    Dictionary<int, Platform[]> PlatformArrDic = new Dictionary<int, Platform[]>();
    internal void Active()
    {
        Vector3 pos = SpawnPosTrf.position;
        int platformGroupSum = 0;

        foreach(Data data in DataArr)
        {
            platformGroupSum += data.GroupCount;
            Debug.Log($"platformGroupSum :{platformGroupSum}");
            while(platformNum < platformGroupSum)
            {
                int platfromID = data.GetPlatformID();
                pos = ActiveOne(pos,platfromID);
                platformNum++;
            }
        }
    }
    private Vector3 ActiveOne(Vector3 pos,int platformID)
    {
        Platform[] platforms = PlatformArrDic[platformID];
        
        int randID = Random.Range(0, platforms.Length);
        Platform randomplatform = platforms[randID];

        Platform platform = Instantiate(randomplatform);
        pos.x=Random.Range(GapX_Max,GapX_Min);
        if (platformNum != 0)
            pos = pos + Vector3.up * platform.GatHelfSizeY();
        platform.Active(pos);

        float gap = Random.Range(GapIntervaMin,GapIntervaMax);
        pos += Vector3.up * (platform.GatHelfSizeY()+gap);
        return pos;
    }
    internal void Init()
    {
        PlatformArrDic.Add(0, SmallPlatformArr);
        PlatformArrDic.Add(1, MiddlePlatformArr);
        PlatformArrDic.Add(2, LargePlatformArr);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
