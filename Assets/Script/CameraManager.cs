using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    [SerializeField] private GameObject player;

    [SerializeField] private SpriteRenderer bgSrdr;
    float cameraWidth;

    internal void Init()
    {
        instance = this;

        Camera camera = Camera.main;
        float cameraHeight = camera.orthographicSize * 2f;
        cameraWidth =cameraHeight*camera.aspect;
    }

    void Start()
    {
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(0, player.transform.position.y + 2f, -10);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);

            // 배경 스프라이트 크기 업데이트
            float bgUpY = bgSrdr.transform.position.y + bgSrdr.size.y / 2; // 중앙 기준으로 변경
            float cameraUpY = Camera.main.transform.position.y + cameraWidth / 2;

            float growthAmount = 0.25f;
            if (bgUpY <= cameraUpY)
            {
                bgSrdr.size = new Vector2(bgSrdr.size.x, bgSrdr.size.y + growthAmount); // x 방향 늘리기 제거
            }
        }
    }
}