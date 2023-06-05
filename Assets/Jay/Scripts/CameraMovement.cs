using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // ���� ��� ĳ������ Transform ������Ʈ

    public float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�

    public Vector3 offset; // ī�޶�� ��� ĳ���� ���� �Ÿ� ����

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // ��� ĳ���� ��ġ�� offset�� ���� ��ġ

        // SmoothDamp �Լ��� ����Ͽ� ���� ��ġ���� ��ǥ ��ġ�� �ε巴�� �̵�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
