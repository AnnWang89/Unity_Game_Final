using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knight_Controller : MonoBehaviour
{
    Animator animator;
    CharacterController charController;
    private float time = 0;
    public bool isRun = true;
    public float speed = 10;
    public Vector3 dir;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //charController = GetComponent<CharacterController>();

        dir = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        animator.SetBool("run", true);

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//定時
        if (time > 3)//3秒改變一次狀態，讓遊戲物體可以停停走走，不然很僵硬
        {
            ChangeState();
        }

        if (isRun)
        {
            animator.SetBool("wait", false);
            animator.SetBool("run", true);
            transform.localPosition += dir.normalized * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool("run", false);
            animator.SetBool("wait", true);
            Debug.Log("wait");
        }
    }

    void ChangeState()
    {
        int value = Random.Range(0, 2);
        if (value == 0) //停下來
        {
            isRun = false;
        }
        else //繼續走
        {
            if (!isRun)//如果本來是停下來的，現在變爲走動，那就轉一下方向
            {
                dir = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            }
            isRun = true;
        }
        time = 0;//定時器清零
    }
}
