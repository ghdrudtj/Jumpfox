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
    /*public IEnumerator OnFollowCor(Vector2 targetPos)
    {
    }
    public void OnFollow(Vector2 targePos)
    {
        StartCoroutine(OnFollowCor(targePos));
    }*/
    void Start()
    {
        
    }

    void Update()
    {
        if (player != null)
        {
            player =GameObject.FindGameObjectWithTag("Player");
        }
        transform.position = new Vector3(0, player.transform.position.y+ 3.25f, -10);
        
    }
}
