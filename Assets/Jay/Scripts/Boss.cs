using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

//태어나면 목적지로 이동하고싶다
//이동이 끝나면 애니메이션을 하고 싶다
//
public class Boss : MonoBehaviour
{
    const int MOVE = 0;
    const int FLY = 1;

    int state;
    public float speed = 1f;
    public Animator anim;
    public Transform moveTarget;
    // Start is called before the first frame update
    void Start()
    {
        state = MOVE;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case MOVE:
                UpdateMove();
                break;
            case FLY:
                UpdateFly();
                break;
        }
    }

    private void UpdateMove()
    {
        Vector3 dir = moveTarget.position - transform.position;
        transform.position = dir.normalized * speed * Time.deltaTime;

        if(dir.magnitude < 0.1f)
        {
            transform.position = moveTarget.position;
            state = FLY;
        }
    }
    public GameObject target;
    public float currentTime;
    public float FlyTime = 5f;
    private void UpdateFly()
    {
        //anim.SetTrigger("Fly");
        //currentTime += Time.deltaTime;
        //if(currentTime > FlyTime)
        //{
        //    currentTime = 0;
        //    GameObject player = Instantiate(target);
        //}
    }
}
