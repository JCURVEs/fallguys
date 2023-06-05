using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    public float jumpForce = 5f; // 점프 힘
    public float gravity = -9.81f; // 중력 가속도


    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isJumping;
    private float verticalVelocity = 0f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 forwardMovement = transform.forward * moveVertical;
        Vector3 rightMovement = transform.right * moveHorizontal;

        moveDirection = forwardMovement + rightMovement;
        moveDirection.Normalize();
        moveDirection *= moveSpeed;

        if (characterController.isGrounded)
        {

            isJumping = false;

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;
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
