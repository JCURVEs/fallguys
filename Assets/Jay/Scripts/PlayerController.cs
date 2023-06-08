using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f; // 이동 속도
    public float rotationSpeed = 180f; // 회전 속도
    public float jumpForce = 10f; // 점프 힘
    public float gravity = -9.81f; // 중력 가속도

    public GameObject rotationObject;

    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isJumping = false;
    private float verticalVelocity = 0f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 이동 방향 계산
        Vector3 forwardMovement = transform.forward * moveVertical;
        Vector3 rightMovement = transform.right * moveHorizontal;
        moveDirection = forwardMovement + rightMovement;
        moveDirection.Normalize();
        moveDirection *= moveSpeed;

        if (Input.GetKeyDown(KeyCode.A))
            rotationObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        else if (Input.GetKeyDown(KeyCode.D))
            rotationObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        else if (Input.GetKeyDown(KeyCode.S))
            rotationObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetKeyDown(KeyCode.A))
                rotationObject.transform.rotation = Quaternion.Euler(0f, -45f, 0f);
            else if (Input.GetKeyDown(KeyCode.D))
                rotationObject.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            else
                rotationObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


        //// 플레이어가 a를 누르면 캡슐의 로테이션 속성 y가 -90
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, -90f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //    print("button : a");
        //}
        //// 플레이어가 d를 누르면 캡슐의 로테이션 y가 90
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, 90f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //    print("button : d");
        //}
        //// 플레이어가 s를 누르면 캡슐의 로테이션 y가 180
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, 180f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //    print("button : s");
        //}
        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, 0f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //}
        //else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, -45f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //}
        //else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        //{
        //    Quaternion rotation = Quaternion.Euler(0f, 45f, 0f);
        //    rotationObject.transform.rotation = rotation;
        //}

        if (characterController.isGrounded)
        {
            isJumping = false;

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity += jumpForce;
            }
            else
            {
                verticalVelocity = 0f;
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        moveDirection.y = verticalVelocity;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
