using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRecticle : MonoBehaviour
{
    // 회전 속도(초당 각도)
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        // 필요 시 초기화 코드 작성
    }

    // Update is called once per frame
    void Update()
    {
        // Y축 기준으로 렉티클 회전
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}