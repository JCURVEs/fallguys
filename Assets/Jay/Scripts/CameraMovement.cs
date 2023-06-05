using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // 따라갈 대상 캐릭터의 Transform 컴포넌트

    public float smoothSpeed = 0.125f; // 카메라 이동 속도

    public Vector3 offset; // 카메라와 대상 캐릭터 간의 거리 조절

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // 대상 캐릭터 위치에 offset을 더한 위치

        // SmoothDamp 함수를 사용하여 현재 위치에서 목표 위치로 부드럽게 이동
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
