using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private bool IsGround;
    public float rotateSpeed = 10f;
    public float jumpForce = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = h * transform.right + v * transform.forward;
        //dir.Normalize();
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        Vector3 velocity = dir * speed;
        rb.MovePosition(transform.position + velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {

        }
    }
}
