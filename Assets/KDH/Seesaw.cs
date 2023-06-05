using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw : MonoBehaviour
{
    public float ropeLength = 5f; // 시소 길이
    public float gravity = 9.81f; // 중력 가속도
    public float damping = 0.99f; // 감쇠 계수

    private float angle; // 현재 각도
    private float angularVelocity; // 각속도

    void Start()
    {
        // 초기 각도와 각속도 설정
        angle = 45f;
        angularVelocity = 0f;
    }

    void Update()
    {
        // 시소 각도와 각속도 갱신
        float acceleration = -gravity / ropeLength * Mathf.Sin(angle);
        angularVelocity += acceleration * Time.deltaTime;
        angle += angularVelocity * Time.deltaTime;

        // 각도를 회전으로 변환하여 시소의 위치 업데이트
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        // 시소 각속도 감쇠
        angularVelocity *= damping;
    }
}
